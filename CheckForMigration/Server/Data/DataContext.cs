using FidaBlazorNet6.Shared.Email.Verification;
using FidaBlazorNet6.Shared.Models.Account;
using FidaBlazorNet6.Shared.Models.Csv;
using FidaBlazorNet6.Shared.Models.General.Reports;
using FidaBlazorNet6.Shared.Models.Leads;
using FidaBlazorNet6.Shared.Models.Leads.Tasks.WorkTaskAutomation;
using FidaBlazorNet6.Shared.Models.Leads.Tasks.WorkTaskAutomation.WorkTasksActions;
using FidaBlazorNet6.Shared.Models.Leads.Tasks.WorkTasks;
using FidaBlazorNet6.Shared.Models.Leads.Tasks.WorkTasks.WT_Email;
using FidaBlazorNet6.Shared.Models.Leads.Tasks.WorkTasksGeneralParameters;
using FidaBlazorNet6.Shared.Models.Leads.Tasks.WorkTaskTemplates;
using FidaBlazorNet6.Shared.Models.Leads.TmkSheetTemplates;
using FidaBlazorNet6.Shared.Models.Leads.TmkSheetTemplates.Layout;
using FidaBlazorNet6.Shared.Models.Leads.WorkSheets;
using FidaBlazorNet6.Shared.Models.Menus;
using FidaBlazorNet6.Shared.Models.Route;
using FidaBlazorNet6.Shared.Utility;
using FidaBlazorUI_Share.Models;
using FidaBlazorUI_Share.Models.Email;
using FidaBlazorUI_Share.Models.Language;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace CheckForMigration.Server.Data
{
    public class DataContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
                               IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DbSet<NavMenuItem> NavMenuItems { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<SubMenuHeader> SubMenuHeaders { get; set; }
        public DbSet<SubMenuList> SubMenuLists { get; set; }
        public DbSet<AppDynamicNavMenu> AppDynamicNavMenus { get; set; }
        public DbSet<BaseLangCode> BaseLangCodes { get; set; }
        public DbSet<LangTranslation> LangTranslations { get; set; }
        public DbSet<LanguageCode> LanguageCodes { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<EmailMessage> EmailMessages { get; set; }
        public DbSet<EmailAttachment> EmailAttachments { get; set; }
        public DbSet<EmailHeader> EmailHeaders { get; set; }
        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<CsvMapTemplate> CsvMapTemplates { get; set; }
        public DbSet<TmkSheetTemplate> TmkSheetTemplates { get; set; }
        public DbSet<TmkSheetField> TmkSheetFields { get; set; }
        public DbSet<WorkSheet> WorkSheets { get; set; }
        public DbSet<WorkSheetField> WorkSheetFields { get; set; }
        public DbSet<WorkSheetAssignment> WorkSheetAssignments { get; set; }
        public DbSet<TmkLayoutTemplate> TmkLayoutTemplates { get; set; }
        public DbSet<WorkTask> WorkTasks { get; set; }
        public DbSet<WorkTaskTemplate> WorkTaskTemplates { get; set; }
        public DbSet<FidaVehicle> FidaVehicles { get; set; }
        public DbSet<VerifiedEmail> VerifiedEmails { get; set; }
        public DbSet<WtEmail> WtEmails { get; set; }
        public DbSet<EmailEvent> EmailEvents { get; set; }
        public DbSet<TaskAutomation> TaskAutomations { get; set; }
        public DbSet<Report> Reports { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region User
            builder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            builder.Entity<User>()
                .HasOne(a => a.Profile)
                .WithOne(b => b.ApplicationUser)
                .HasForeignKey<UserProfile>(b => b.UserId);

            builder.Entity<User>()
                .HasOne(a => a.AppDynamicNavMenu)
                .WithOne(b => b.ApplicationUser)
                .HasForeignKey<AppDynamicNavMenu>(b => b.AppId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.Adresses)
                .WithOne(a => a.User)
                .HasForeignKey(fk => fk.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.SecondaryEMailAddresses)
                .WithOne(a => a.User)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.Entity<User>()
                .HasMany(u => u.PhoneNumbers)
                .WithOne(a => a.User)
                .HasForeignKey(fk => fk.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.IdentityNumbers)
                .WithOne(a => a.User)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.Entity<User>()
                .HasMany(u => u.EmailMessages)
                .WithOne()
                .HasForeignKey(fk => fk.UserId)
                .IsRequired();

            builder.Entity<User>()
                .HasMany(u => u.EmailTemplates)
                .WithOne()
                .HasForeignKey(tp => tp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion

            #region Language

            builder.Entity<LangTransPage>(langTransPage =>
            {

                langTransPage.HasKey(ltp => new { ltp.PageId, ltp.langTranslationId });

                langTransPage
                    .HasOne(pg => pg.Page)
                    .WithMany(p => p.LangTransPages)
                    .HasForeignKey(fk => fk.PageId)
                    .IsRequired();

                langTransPage
                    .HasOne(lt => lt.LangTranslation)
                    .WithMany(t => t.LangTransPages)
                    .HasForeignKey(fk => fk.langTranslationId)
                    .IsRequired();
            });

            builder.Entity<BaseLangCode>()
                .HasMany(blc => blc.LangTranslations)
                .WithOne(tl => tl.BaseLang)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.Entity<LanguageCode>()
                .HasMany(lc => lc.LangTranslations)
                .WithOne(tl => tl.LangCode)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
            #endregion

            #region Menu
            builder.Entity<SubMenuHeader>()
                .HasOne(a => a.NavMenuItem)
                .WithOne(b => b.SubMenuHeader)
                .HasForeignKey<NavMenuItem>(b => b.AppId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<SubMenu>()
                .HasOne(a => a.SubMenuHeader)
                .WithOne(b => b.SubMenu)
                .HasForeignKey<SubMenuHeader>(b => b.AppId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<SubMenu>()
                .HasOne(a => a.SubMenuList)
                .WithOne(b => b.SubMenu)
                .HasForeignKey<SubMenuList>(b => b.AppId)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Emails

            builder.Entity<EmailTemplate>()
                .HasMany(et => et.Attachments)
                .WithOne(at => at.EmailTemplate)
                .HasForeignKey(et => et.EmailTemplateId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<EmailTemplate>()
                .Property(wta => wta.ClassDataSource)
                .HasConversion(pt => pt.Name, pt => pt.GetTypeByEntityName());

            builder.Entity<EmailMessage>()
                .HasMany(em => em.Attachments)
                .WithOne(at => at.EmailMessage)
                .HasForeignKey(ea => ea.EmailMessageId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<EmailMessage>()
                .HasMany(em => em.FromAddresses)
                .WithOne(fa => fa.FromEmailMessage)
                .HasForeignKey(fa => fa.FromEmailMessageId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<EmailMessage>()
                .HasMany(em => em.BccAddresses)
                .WithOne(fa => fa.BccEmailMessage)
                .HasForeignKey(fa => fa.BccEmailMessageId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<EmailMessage>()
                .HasMany(em => em.CcAddresses)
                .WithOne(fa => fa.CcEmailMessage)
                .HasForeignKey(fa => fa.CcEmailMessageId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<EmailMessage>()
                .HasMany(em => em.ToAddresses)
                .WithOne(fa => fa.ToEmailMessage)
                .HasForeignKey(fa => fa.ToEmailMessageId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<EmailMessage>()
                .HasMany(em => em.ReplyTo)
                .WithOne(fa => fa.ReplyToEmailMessage)
                .HasForeignKey(fa => fa.ReplyToEmailMessageId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<EmailMessage>()
                .HasMany(em => em.Headers)
                .WithOne(he => he.EmailMessage)
                .HasForeignKey(he => he.EmailMessageId)
                .IsRequired();

            builder.Entity<EmailMessage>()
                .HasMany(em => em.MessageFlags)
                .WithOne(he => he.EmailMessage)
                .HasForeignKey(mf => mf.EmailMessageId)
                .IsRequired();

            builder.Entity<EmailMessage>()
                .HasMany(em => em.References)
                .WithOne(he => he.EmailMessage)
                .HasForeignKey(re => re.EmailMessageParentId)
                .IsRequired();

            builder.Entity<EmailMessage>()
                .HasOne(em => em.Uid)
                .WithOne(ui => ui.EmailMessage)
                .HasForeignKey<EmailUid>(fk => fk.Id)
                .IsRequired();

            builder.Entity<EmailMessage>()
                .HasMany(em => em.EmailEvents)
                .WithOne(ev => ev.EmailMessage)
                .HasForeignKey(fk => fk.EmailMessageId)
                .IsRequired();


            builder.Entity<EmailMessageId>();


            #endregion

            #region TmkSheets

            builder.Entity<TmkTemplateRole>(tmkTR =>
            {
                tmkTR.HasKey(tr => new { tr.TemplateId, tr.RoleId });

                tmkTR.HasOne(tr => tr.Role)
                    .WithMany(r => r.TmkTemplateRoles)
                    .HasForeignKey(tr => tr.RoleId)
                    .IsRequired();

                tmkTR.HasOne(tr => tr.TmkSheetTemplate)
                    .WithMany(r => r.Roles)
                    .HasForeignKey(ur => ur.TemplateId)
                    .IsRequired();
            });

            builder.Entity<TmkSheetTemplate>()
                .HasMany(tmkt => tmkt.LayoutTemplates)
                .WithOne(lyt => lyt.TmkTemplate)
                .HasForeignKey(fk => fk.TmkTemplateId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TmkLayoutTemplate>()
                .HasMany(lyt => lyt.LayoutRows)
                .WithOne(lyr => lyr.TmkLayout)
                .HasForeignKey(fk => fk.TmkLayoutId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TmkLayoutRow>()
                .HasMany(lyr => lyr.LayoutColumns)
                .WithOne(lyc => lyc.LayoutRow)
                .HasForeignKey(fk => fk.LayoutRowId)
                .OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<>()
            //    .HasMany(fld => fld.Fields)
            //    .WithOne(st => st.SheetTemplate)
            //    .HasForeignKey(fk => fk.SheetTemplateId)
            //    .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TmkSheetField>()
                .HasMany(sli => sli.SelectItems)
                .WithOne(sf => sf.TmkSheetField)
                .HasForeignKey(fk => fk.TmkSheetFieldId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion

            #region Lead

            builder.Entity<Lead>()
                .HasMany(ld => ld.Contacts)
                .WithOne(co => co.Lead)
                .HasForeignKey(fk => fk.LeadId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Lead>()
                .HasOne(ld => ld.LeadAddress)
                .WithOne(ua => ua.Lead)
                .HasForeignKey<UserAddress>(ua => ua.LeadId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Contact>()
                .HasMany(co => co.PhoneNumbers)
                .WithOne(ph => ph.Contact)
                .HasForeignKey(fk => fk.ContactId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Contact>()
                .HasMany(co => co.Emails)
                .WithOne()
                .HasForeignKey(fk => fk.ContactId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion

            #region Csv

            builder.Entity<CsvMapTemplate>()
                .HasMany(csvt => csvt.CsvMaps)
                .WithOne(csvm => csvm.MapTemplate)
                .HasForeignKey(fk => fk.MapTemplateId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion

            #region WorkSheet

            builder.Entity<WorkSheetField>()
                .HasMany(wsf => wsf.SelectItems)
                .WithOne(wssf => wssf.WorkSheetField)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion

            #region WorkTask

            builder.Entity<WorkTask>()
                .HasMany(wt => wt.TaskFields)
                .WithOne(tsf => tsf.WorkTask)
                .HasForeignKey(wt => wt.WorkTaskId)
                .IsRequired();

            builder.Entity<WorkTask>()
                .HasOne(wt => wt.User)
                .WithMany(us => us.WorkTasks)
                .HasForeignKey(wt => wt.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<WorkTask>()
                .HasOne(wt => wt.WorkSheet)
                .WithMany(ws => ws.WorkTasks)
                .HasForeignKey(wt => wt.WorkSheetId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<WorkTaskTemplate>()
                .HasOne(wtt => wtt.TmkSheetTemplate)
                .WithMany(tmst => tmst.WorkTaskTemplates)
                .HasForeignKey(wtt => wtt.TmkSheetTemplateId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<WorkTaskTemplate>()
                .HasMany(wtt => wtt.WorkTasks)
                .WithOne(wt => wt.Template)
                .HasForeignKey(wt => wt.TemplateId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<WorkTaskTemplate>()
                .HasMany(wtt => wtt.TaskFields)
                .WithOne(wtf => wtf.WorkTaskTemplate)
                .HasForeignKey(wtf => wtf.WorkTaskTemplateId)
                .IsRequired();

            builder.Entity<TaskFieldTemplate>()
                .HasMany(tft => tft.DropSelectItems)
                .WithOne(dsi => dsi.TaskField)
                .HasForeignKey(dsi => dsi.TaskFieldTemplateId)
                .IsRequired();

            builder.Entity<WorkTaskParameter>()
                .HasMany(wtp => wtp.DayWorkWindows)
                .WithOne(dww => dww.WorkTaskParameter)
                .HasForeignKey(dww => dww.WorkTaskParameterId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<WorkTaskParameter>()
                .HasOne(wtp => wtp.User)
                .WithMany(us => us.WorkTaskParameters)
                .HasForeignKey(wtp => wtp.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<WtEmail>()
                .HasMany(wma => wma.BccAddresses)
                .WithOne()
                .HasForeignKey(fk => fk.BccWtEmailMessageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<WtEmail>()
                .HasMany(wma => wma.CcAddresses)
                .WithOne()
                .HasForeignKey(fk => fk.CcWtEmailMessageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<WtEmail>()
                .HasMany(wma => wma.ToAddresses)
                .WithOne()
                .HasForeignKey(fk => fk.ToWtEmailMessageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<WtEmail>()
                .HasMany(wma => wma.FromAddresses)
                .WithOne()
                .HasForeignKey(fk => fk.FromWtEmailMessageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<WT_Action>()
                .Property(wta => wta.ClassType)
                .HasConversion(pt => pt.Name, pt => pt.GetTypeByEntityName());

            builder.Entity<WT_ActionTemplate>()
                .Property(wta => wta.ClassType)
                .HasConversion(pt => pt.Name, pt => pt.GetTypeByEntityName());

            #endregion

            #region Work Task Automations

            builder.Entity<EmailMessage>()
                .HasOne<WT_Action>()
                .WithOne(wta => wta.EmailMessage)
                .HasForeignKey<WT_Action>(fk => fk.EmailMessageId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion

            #region FidaRoute
            builder.Entity<FidaVehicle>()
                .HasOne(u => u.User)
                .WithMany(us => us.FidaVehicles)
                .HasForeignKey(fk => fk.UserId);

            builder.Entity<FidaUserRouteToken>()
                .HasOne(ut => ut.User)
                .WithOne(u => u.RouteToken)
                .HasForeignKey<FidaUserRouteToken>(fk => fk.UserId);

            builder.Entity<FidaVehicle>()
                .HasOne(fv => fv.StartAddress)
                .WithOne()
                .HasForeignKey<FidaVehicle>(fv => fv.StartAddressId)
                .IsRequired();

            builder.Entity<FidaVehicle>()
                .HasOne(fv => fv.EndAddress)
                .WithOne()
                .HasForeignKey<FidaVehicle>(fv => fv.EndAddressId)
                .IsRequired();

            #endregion

            builder.HasPostgresEnum<DayOfWeek>();

            #region Reports

            builder.Entity<ReportRole>(reportRole =>
            {
                reportRole.HasKey(rr => new { rr.ReportId, rr.RoleId });

                reportRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.ReportRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                reportRole.HasOne(ur => ur.Report)
                    .WithMany(r => r.ReportRoles)
                    .HasForeignKey(ur => ur.ReportId)
                    .IsRequired();
            });

            builder.Entity<Report>()
                .HasOne(rpt => rpt.User)
                .WithMany(us => us.Reports)
                .HasForeignKey(fk => fk.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion
        }
    }
}

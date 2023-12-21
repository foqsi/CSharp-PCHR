﻿// <auto-generated />
using System;
using Davis_FinalProject_Cs.Models.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Davis_FinalProject_Cs.Migrations
{
    [DbContext(typeof(PCHRContext))]
    [Migration("20231210015052_AddEmergencyContactDetails")]
    partial class AddEmergencyContactDetails
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.AllergyTbl", b =>
                {
                    b.Property<string>("PatientId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PATIENT_ID")
                        .IsFixedLength();

                    b.Property<string>("AllergyId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("ALLERGY_ID")
                        .IsFixedLength();

                    b.Property<string>("Allergen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ALLERGEN");

                    b.Property<string>("Note")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("NOTE");

                    b.Property<DateOnly>("OnsetDate")
                        .HasColumnType("date")
                        .HasColumnName("ONSET_DATE");

                    b.HasKey("PatientId", "AllergyId");

                    b.ToTable("ALLERGY_TBL");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.Condition", b =>
                {
                    b.Property<string>("PatientId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PATIENT_ID")
                        .IsFixedLength();

                    b.Property<string>("ConditionId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("CONDITION_ID")
                        .IsFixedLength();

                    b.Property<bool>("Acute")
                        .HasColumnType("bit")
                        .HasColumnName("ACUTE");

                    b.Property<bool>("Chronic")
                        .HasColumnType("bit")
                        .HasColumnName("CHRONIC");

                    b.Property<string>("Condition1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CONDITION");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOTE");

                    b.Property<DateOnly>("OnsetDate")
                        .HasColumnType("date")
                        .HasColumnName("ONSET_DATE");

                    b.HasKey("PatientId", "ConditionId");

                    b.ToTable("CONDITION");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.ImmunizationTbl", b =>
                {
                    b.Property<string>("PatientId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PATIENT_ID")
                        .IsFixedLength();

                    b.Property<string>("ImmunizationId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("IMMUNIZATION_ID")
                        .IsFixedLength();

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("DATE");

                    b.Property<string>("Immunization")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IMMUNIZATION");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOTE");

                    b.HasKey("PatientId", "ImmunizationId");

                    b.ToTable("IMMUNIZATION_TBL");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.MedProcTbl", b =>
                {
                    b.Property<string>("PatientId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PATIENT_ID")
                        .IsFixedLength();

                    b.Property<string>("ProcedureId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PROCEDURE_ID")
                        .IsFixedLength();

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("DATE");

                    b.Property<string>("Doctor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DOCTOR");

                    b.Property<string>("MedProcedure")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MED_PROCEDURE");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOTE");

                    b.HasKey("PatientId", "ProcedureId");

                    b.ToTable("MED_PROC_TBL");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.MedicationTbl", b =>
                {
                    b.Property<string>("PatientId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PATIENT_ID")
                        .IsFixedLength();

                    b.Property<string>("MedId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("MED_ID")
                        .IsFixedLength();

                    b.Property<bool>("Chronic")
                        .HasColumnType("bit")
                        .HasColumnName("CHRONIC");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("DATE");

                    b.Property<string>("Medication")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MEDICATION");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOTE");

                    b.HasKey("PatientId", "MedId");

                    b.ToTable("MEDICATION_TBL");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.PatientTbl", b =>
                {
                    b.Property<string>("PatientId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PATIENT_ID")
                        .IsFixedLength();

                    b.Property<string>("AddressCity")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("ADDRESS_CITY");

                    b.Property<string>("AddressState")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("ADDRESS_STATE");

                    b.Property<string>("AddressStreet")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ADDRESS_STREET");

                    b.Property<string>("AddressZip")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("ADDRESS_ZIP")
                        .IsFixedLength();

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("DATE_Of_BIRTH");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .HasColumnName("EMAIL")
                        .IsFixedLength();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("FIRST_NAME");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("GENDER");

                    b.Property<string>("Initials")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("INITIALS");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("LAST_NAME");

                    b.Property<string>("PhoneHome")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PHONE_HOME")
                        .IsFixedLength();

                    b.Property<string>("PhoneMobile")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PHONE_MOBILE")
                        .IsFixedLength();

                    b.Property<string>("PrimaryId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PRIMARY_ID")
                        .IsFixedLength();

                    b.Property<string>("Title")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("TITLE")
                        .IsFixedLength();

                    b.HasKey("PatientId");

                    b.ToTable("PATIENT_TBL");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.PerDetailsTbl", b =>
                {
                    b.Property<string>("PatientId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PATIENT_ID")
                        .IsFixedLength();

                    b.Property<string>("BloodType")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("BLOOD_TYPE")
                        .IsFixedLength();

                    b.Property<short?>("HeightInches")
                        .HasColumnType("smallint")
                        .HasColumnName("HEIGHT_INCHES");

                    b.Property<bool?>("HivStatus")
                        .HasColumnType("bit")
                        .HasColumnName("HIV_STATUS");

                    b.Property<bool?>("OrganDonor")
                        .HasColumnType("bit")
                        .HasColumnName("ORGAN_DONOR");

                    b.Property<short?>("WeightLbs")
                        .HasColumnType("smallint")
                        .HasColumnName("WEIGHT_LBS");

                    b.HasKey("PatientId");

                    b.ToTable("PER_DETAILS_TBL");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.PrimaryCareTbl", b =>
                {
                    b.Property<string>("PrimaryId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PRIMARY_ID")
                        .IsFixedLength();

                    b.Property<string>("NameFisrt")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("NAME_FISRT")
                        .IsFixedLength();

                    b.Property<string>("NameLast")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("NAME_LAST")
                        .IsFixedLength();

                    b.Property<string>("PhoneMobile")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PHONE_MOBILE")
                        .IsFixedLength();

                    b.Property<string>("PhoneOffice")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PHONE_OFFICE")
                        .IsFixedLength();

                    b.Property<string>("Specialty")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("SPECIALTY")
                        .IsFixedLength();

                    b.Property<string>("Title")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("TITLE")
                        .IsFixedLength();

                    b.HasKey("PrimaryId");

                    b.ToTable("PRIMARY_CARE_TBL");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.TestTbl", b =>
                {
                    b.Property<string>("PatientId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("PATIENT_ID")
                        .IsFixedLength();

                    b.Property<string>("TestId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("TEST_ID")
                        .IsFixedLength();

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("DATE");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOTE");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("RESULT");

                    b.Property<string>("Test")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TEST");

                    b.HasKey("PatientId", "TestId");

                    b.ToTable("TEST_TBL");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.AllergyTbl", b =>
                {
                    b.HasOne("Davis_FinalProject_Cs.Models.DataLayer.PatientTbl", "Patient")
                        .WithMany("AllergyTbls")
                        .HasForeignKey("PatientId")
                        .IsRequired()
                        .HasConstraintName("FK_ALLERGY_TBL_PATIENT_TBL");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.Condition", b =>
                {
                    b.HasOne("Davis_FinalProject_Cs.Models.DataLayer.PatientTbl", "Patient")
                        .WithMany("Conditions")
                        .HasForeignKey("PatientId")
                        .IsRequired()
                        .HasConstraintName("FK_CONDITION_PATIENT_TBL");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.ImmunizationTbl", b =>
                {
                    b.HasOne("Davis_FinalProject_Cs.Models.DataLayer.PatientTbl", "Patient")
                        .WithMany("ImmunizationTbls")
                        .HasForeignKey("PatientId")
                        .IsRequired()
                        .HasConstraintName("FK_IMMUNIZATION_TBL_PATIENT_TBL");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.MedProcTbl", b =>
                {
                    b.HasOne("Davis_FinalProject_Cs.Models.DataLayer.PatientTbl", "Patient")
                        .WithMany("MedProcTbls")
                        .HasForeignKey("PatientId")
                        .IsRequired()
                        .HasConstraintName("FK_MED_PROC_TBL_PATIENT_TBL");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.MedicationTbl", b =>
                {
                    b.HasOne("Davis_FinalProject_Cs.Models.DataLayer.PatientTbl", "Patient")
                        .WithMany("MedicationTbls")
                        .HasForeignKey("PatientId")
                        .IsRequired()
                        .HasConstraintName("FK_MEDICATION_TBL_PATIENT_TBL");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.PerDetailsTbl", b =>
                {
                    b.HasOne("Davis_FinalProject_Cs.Models.DataLayer.PatientTbl", "Patient")
                        .WithOne("PerDetailsTbl")
                        .HasForeignKey("Davis_FinalProject_Cs.Models.DataLayer.PerDetailsTbl", "PatientId")
                        .IsRequired()
                        .HasConstraintName("FK_PER_DETAILS_TBL_PATIENT_TBL");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.TestTbl", b =>
                {
                    b.HasOne("Davis_FinalProject_Cs.Models.DataLayer.PatientTbl", "Patient")
                        .WithMany("TestTbls")
                        .HasForeignKey("PatientId")
                        .IsRequired()
                        .HasConstraintName("FK_TEST_TBL_PATIENT_TBL");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Davis_FinalProject_Cs.Models.DataLayer.PatientTbl", b =>
                {
                    b.Navigation("AllergyTbls");

                    b.Navigation("Conditions");

                    b.Navigation("ImmunizationTbls");

                    b.Navigation("MedProcTbls");

                    b.Navigation("MedicationTbls");

                    b.Navigation("PerDetailsTbl");

                    b.Navigation("TestTbls");
                });
#pragma warning restore 612, 618
        }
    }
}

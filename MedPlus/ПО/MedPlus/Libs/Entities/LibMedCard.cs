using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs
{
    public static class LibMedCard
    {
        public static string GetFullName(MedCard card)
        {
            return $"{card.LName} {card.FName} {card.MName}";
        }
        public static bool AddCard(MedCard card)
        {
            try
            {
                LibDB.GetContext().MedCards.Add(card);
                LibDB.GetContext().SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void SetMedCardDependences(MedCard card)
        {
            card.Spr_Country = LibDB.GetContext().Spr_Country.Find(card.CountryID);
            card.Spr_DeliveryPeriod = LibDB.GetContext().Spr_DeliveryPeriod.Find(card.DeliveryPeriodID);
            card.Spr_DeliveryType = LibDB.GetContext().Spr_DeliveryType.Find(card.DeliveryTypeID);
            card.Spr_Denial = LibDB.GetContext().Spr_Denial.Find(card.DenialID);
            card.Spr_Department = LibDB.GetContext().Spr_Department.Find(card.DepartmentID_Discharge);
            card.Spr_Department1 = LibDB.GetContext().Spr_Department.Find(card.DepartmentID_Receipt);
            card.Spr_Diagnosis = LibDB.GetContext().Spr_Diagnosis.Find(card.DiagnosisCode_Discharge);
            card.Spr_Diagnosis1 = LibDB.GetContext().Spr_Diagnosis.Find(card.DiagnosisCode_LPU);
            card.Spr_Diagnosis2 = LibDB.GetContext().Spr_Diagnosis.Find(card.DiagnosisCode_PO);
            card.Spr_DocumentType = LibDB.GetContext().Spr_DocumentType.Find(card.DocumentTypeID);
            card.Spr_Gender = LibDB.GetContext().Spr_Gender.Find(card.GenderCode);
            card.Spr_HospitalizationType = LibDB.GetContext().Spr_HospitalizationType.Find(card.HospitalizationTypeID);
            card.Spr_InjuryType = LibDB.GetContext().Spr_InjuryType.Find(card.InjuryTypeID);
            card.Spr_KLADR = LibDB.GetContext().Spr_KLADR.Find(card.KLADR_ID);
            card.Spr_PaymentType = LibDB.GetContext().Spr_PaymentType.Find(card.PaymentTypeID);
            card.Spr_SendingOrganisation = LibDB.GetContext().Spr_SendingOrganisation.Find(card.SendingOrdanisationID);
            card.Spr_SignOfDischarge = LibDB.GetContext().Spr_SignOfDischarge.Find(card.SignOfDischargeID);
            card.Spr_SignOfResidence = LibDB.GetContext().Spr_SignOfResidence.Find(card.SignOfResidenceID);
            card.Spr_SocialStatus = LibDB.GetContext().Spr_SocialStatus.Find(card.SocialStatusID);
            card.Spr_TreatmentOutcome = LibDB.GetContext().Spr_TreatmentOutcome.Find(card.TreatmentOutcomeID);
        }


        public static List<MedCard> GetMedCards(int offset = 0, string searchText = "")
        {
            System.Data.SqlClient.SqlParameter parameterOffset = new System.Data.SqlClient.SqlParameter("@offset", offset);
            System.Data.SqlClient.SqlParameter parameterSearch = new System.Data.SqlClient.SqlParameter("@search", searchText);
            List<MedCard> rowMedCards = LibDB.GetContext().Database.SqlQuery<MedCard>("SELECT * FROM MedCard WHERE LName + ' ' + FName + ' ' + MName LIKE '%' + @search + '%' ORDER BY ID OFFSET @offset ROWS FETCH NEXT 200 ROWS ONLY", parameterSearch, parameterOffset).ToList();
            
         /*   List<MedCard> medCards = new List<MedCard>();
                for(int i = 0; i < rowMedCards.Count; i++)
                {
                    medCards.Add(LibDB.GetContext().MedCards.Find(rowMedCards[i].ID));
                }
         неэффективный код */
            return rowMedCards;
        }

        public static bool UpdateMedCard(MedCard card)
        {
            System.Data.SqlClient.SqlParameter parameterOffset = new System.Data.SqlClient.SqlParameter("@id", card.ID);
            try
            {
                LibDB.GetContext().MedCards.AddOrUpdate(card);
                LibDB.GetContext().SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public static int GetCountOfCards(string searchText = "")
        {
            int count = 0;
            System.Data.SqlClient.SqlParameter parameterSearch = new System.Data.SqlClient.SqlParameter("@search", searchText);
            count = LibDB.GetContext().Database.SqlQuery<MedCard>("SELECT * FROM MedCard WHERE LName + ' ' + FName + ' ' + MName LIKE '%' + @search + '%' ORDER BY ID", parameterSearch).Count();

            return count;
        }
    }
}

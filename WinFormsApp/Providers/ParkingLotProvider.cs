using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using WinFormsApp.Common;
using WinFormsApp.Models;

namespace WinFormsApp.Providers
{
    class ParkingLotProvider
    {
        public static int SaveData(string MotorType, string PlatNo, string RegistrationNoColour)
        {
            int iNewSlot = 0;
            List<string> listInt = new List<string>();
            for (int i = 1; i <= CommonConstant.TotalParkSlot; i++)
            {
                listInt.Add(i.ToString());
            }

            using (var context = new DbTohaNTTContext())
            {

                var availableSlot = listInt.Where(x => !context.ParkingLots.Select(x => x.Slot).ToList()
                        .Contains(Convert.ToInt32(x))).ToList();

                if (availableSlot.Count == 0)
                    throw new Exception("Parking Slot is Full");


                var newData = new ParkingLot()
                {
                    MotorType = MotorType,
                    PlatNo = PlatNo,
                    RegistrationNoColour = RegistrationNoColour,
                    Slot = Convert.ToInt32(availableSlot.FirstOrDefault())
                };
                context.ParkingLots.Add(newData);


                context.SaveChanges();

                iNewSlot = Convert.ToInt32(availableSlot.FirstOrDefault());
            }

            return iNewSlot;
        }

        internal static List<ParkingLot> GetByRegNo(string searchedType)
        {
            List<ParkingLot> searchedData = new List<ParkingLot>();

            using (var context = new DbTohaNTTContext())
            {
                searchedData = context.ParkingLots.Where(x => x.PlatNo.ToLower().Equals(searchedType.ToLower())).ToList();
            }
            return searchedData;
        }

        internal static (bool, List<string>) GetAllDistinctSlot()
        {
            bool bIsSuccess = false;
            var listData = new List<string>();
            try
            {
                using (var context = new DbTohaNTTContext())
                {

                    listData = context.ParkingLots.Select(x => x.Slot.ToString()).ToList();
                }

                bIsSuccess = true;
                return (bIsSuccess, listData);
            }
            catch (Exception ex)
            {
                //If logger is not work maybe server down, log to file
                UtilityClass.LogToFile("InsertLog error:" + ex.ToString());
                bIsSuccess = false;
                return (bIsSuccess, listData);
            }
        }

        internal static (bool, ParkingLot) LeaveByParkId(string searchedType)
        {
            ParkingLot searchedData = new ParkingLot();
            bool bIsSuccess = false;
            try
            {

                using (var context = new DbTohaNTTContext())
                {
                    searchedData = context.ParkingLots.Where(x => x.Slot.ToString().Equals(searchedType.ToLower())).FirstOrDefault();

                    context.ParkingLots.Remove(searchedData);
                    context.SaveChanges();
                }
                bIsSuccess = true;
            }
            catch (Exception ex)
            {
                //If logger is not work maybe server down, log to file
                UtilityClass.LogToFile("InsertLog error:" + ex.ToString());
                bIsSuccess = false;
                searchedData.PlatNo = ex.ToString();
                return (bIsSuccess, searchedData);
            }
            return (bIsSuccess, searchedData);
        }

        internal static List<ParkingLot> GetByPlateColour(string searchedType)
        {
            List<ParkingLot> searchedData = new List<ParkingLot>();

            using (var context = new DbTohaNTTContext())
            {
                searchedData = context.ParkingLots.Where(x => x.RegistrationNoColour.ToLower().Equals(searchedType.ToLower())).ToList();
            }
            return searchedData;
        }

        internal static (bool, List<string>) GetAllRegNoAsync()
        {
            bool bIsSuccess = false;
            var listData = new List<string>();
            try
            {
                using (var context = new DbTohaNTTContext())
                {

                    listData = context.ParkingLots.Select(x => x.PlatNo).ToList();
                }

                bIsSuccess = true;
                return (bIsSuccess, listData);
            }
            catch (Exception ex)
            {
                //If logger is not work maybe server down, log to file
                UtilityClass.LogToFile("InsertLog error:" + ex.ToString());
                bIsSuccess = false;
                return (bIsSuccess, listData);
            }
        }

        internal static List<ParkingLot> GetByVehicleType(string searchedType)
        {
            List<ParkingLot> searchedData = new List<ParkingLot>();

            using (var context = new DbTohaNTTContext())
            {
                searchedData = context.ParkingLots.Where(x => x.MotorType.ToLower().Equals(searchedType.ToLower())).ToList();
            }
            return searchedData;
        }

        internal static List<ParkingLot> GetByEvenOdd(string sEven)
        {
            List<ParkingLot> searchedData = new List<ParkingLot>();

            using (var context = new DbTohaNTTContext())
            {

                var allData = context.ParkingLots.ToList();

                List<string> listeven = new List<string>();
                List<string> listOdd = new List<string>();

                foreach (var item in allData)
                {
                    string PlatNo = Regex.Match(item.PlatNo, "[0-9]{4,5}").Value;
                    if (string.IsNullOrWhiteSpace(PlatNo))
                        continue;

                    int iValue = Convert.ToInt32(PlatNo);
                    if (iValue % 2 == 0)
                    {
                        listeven.Add(item.PlatNo);
                    }
                    else
                    {
                        listOdd.Add(item.PlatNo);
                    }
                }

                if (sEven.ToLower().Equals("odd"))
                    searchedData = (from all in allData
                                    join filters in listOdd on all.PlatNo.ToUpper() equals filters.ToUpper()
                                    select all).ToList();
                else
                    searchedData = (from all in allData
                                    join filters in listeven on all.PlatNo.ToUpper() equals filters.ToUpper()
                                    select all).ToList();
            }
            return searchedData;
        }

        internal static (bool, List<ParkingLot>) GetAllAsync()
        {
            bool bIsSuccess = false;
            var listData = new List<ParkingLot>();
            try
            {
                using (var context = new DbTohaNTTContext())
                {

                    listData = context.ParkingLots.ToList();
                }

                bIsSuccess = true;
                return (bIsSuccess, listData);
            }
            catch (Exception ex)
            {
                //If logger is not work maybe server down, log to file
                UtilityClass.LogToFile("InsertLog error:" + ex.ToString());
                bIsSuccess = false;
                return (bIsSuccess, listData);
            }
        }
    }
}

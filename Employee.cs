using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQl_Day_05
{

    public class Employee
    {
        #region Attribute
        private SecurityLevel EmpSecurityLevel;
        private int EmpId;
        private Gender EmpGender;
        private double EmpSalary;
        private hireDate EmpHD;
        #endregion

        #region Setters&Getters

        #region ID
        public void setEmpId(int _EmpId)
        {
            EmpId = _EmpId;
        }

        public int getEmpId()
        {
            return EmpId;
        }
        #endregion

        #region SecurityLevel
        public void setEmpSecurityLevel(SecurityLevel _EmpSecurityLevel)
        {

            EmpSecurityLevel = _EmpSecurityLevel;
        }
       
        public SecurityLevel getEmpSecurityLevel()
        {
            return EmpSecurityLevel;
        }
        #endregion

        #region Gender
        public void setEmpGender(Gender _EmpGender)
        {
            try
            {
                if (_EmpGender == Gender.F || _EmpGender == Gender.Female || _EmpGender == Gender.M || _EmpGender == Gender.Male)
                {
                    EmpGender = _EmpGender;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public Gender getEmpGender()
        {
            return EmpGender;
        }
        #endregion

        #region Salary
        public void setEmpSalary(double _EmpSalary)
        {
            EmpSalary = _EmpSalary;
        }
        
        public double getEmpSalary()
        {
            return EmpSalary;
        }
        #endregion

        #region DateOfHire
        public void setEmpHD(hireDate _EmpHD)
        {
            EmpHD = _EmpHD;
        }
        
        public string getEmpHD()
        {

            string s = $"{EmpHD.getDay()} - {EmpHD.getMonth()} - {EmpHD.getYear()}";

            return s;

        } 
        #endregion
        
        #endregion

    }
}

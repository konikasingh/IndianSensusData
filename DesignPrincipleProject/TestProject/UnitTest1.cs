using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPrincipleProject;
using DesignPrincipleProject.DataDAO;
using DesignPrincipleProject.DataDAO;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        string stateCodePath = @"E:\vs\DesignPrinciple\DesignPrincipleProject\DesignPrincipleProject\CSVFiles\IndiaStateCode.csv";
        string stateCensusPath = @"E:\vs\DesignPrinciple\DesignPrincipleProject\DesignPrincipleProject\CSVFiles\IndiaStateCensusData.csv";
        string wrongCensusPath = @"E:\vs\DesignPrinciple\DesignPrincipleProject\DesignPrincipleProject\CSVFiles\WrongIndiaStateCensusData.csv";
        string wrongCensusCodePath = @"E:\vs\DesignPrinciple\DesignPrincipleProject\DesignPrincipleProject\CSVFiles\WrongIndiaStateCode.csv";
        string wrongHeaderStateCodePath = @"E:\vs\DesignPrinciple\DesignPrincipleProject\DesignPrincipleProject\CSVFiles\WrongIndiaStateCode.csv";
        string delimiterStateCodePath = @"E:\vs\DesignPrinciple\DesignPrincipleProject\DesignPrincipleProject\CSVFiles\DelimiterIndiaStateCode.csv";
        string delimiterStateCensusPath = @"E:\vs\DesignPrinciple\DesignPrincipleProject\DesignPrincipleProject\CSVFiles\DelimiterIndiaStateCensusData.csv";
        //IndiaCensusDataDemo

        Dictionary<string, CensusDataDAO> stateRecords;


        public void SetUp()
        {
            stateRecords = new Dictionary<string, CensusDataDAO>();

        }




        [TestMethod]
        public void GivenStateCensusCSVShouldReturnRecords()
        {
            //stateRecords=
        }
    }
}
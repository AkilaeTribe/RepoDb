﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SQLite;

namespace RepoDb.SqLite.UnitTests
{
    [TestClass]
    public class DbSettingTest
    {
        [TestInitialize]
        public void Initialize()
        {
            SqLiteBootstrap.Initialize();
        }

        [TestMethod]
        public void TestSqLiteDbSettingAreTableHintsSupportedProperty()
        {
            // Setup
            var setting = DbSettingMapper.Get<SQLiteConnection>();

            // Assert
            Assert.IsFalse(setting.AreTableHintsSupported);
        }

        [TestMethod]
        public void TestSqLiteDbSettingClosingQuoteProperty()
        {
            // Setup
            var setting = DbSettingMapper.Get<SQLiteConnection>();

            // Assert
            Assert.AreEqual("]", setting.ClosingQuote);
        }

        [TestMethod]
        public void TestSqLiteDbSettingDefaultAverageableTypeProperty()
        {
            // Setup
            var setting = DbSettingMapper.Get<SQLiteConnection>();

            // Assert
            Assert.AreEqual(typeof(double), setting.DefaultAverageableType);
        }

        [TestMethod]
        public void TestSqLiteDbSettingDefaultSchemaProperty()
        {
            // Setup
            var setting = DbSettingMapper.Get<SQLiteConnection>();

            // Assert
            Assert.IsNull(setting.DefaultSchema);
        }

        [TestMethod]
        public void TestSqLiteDbSettingIsDbParameterDirectionSettingSupportedProperty()
        {
            // Setup
            var setting = DbSettingMapper.Get<SQLiteConnection>();

            // Assert
            Assert.IsFalse(setting.IsDbParameterDirectionSettingSupported);
        }

        [TestMethod]
        public void TestSqLiteDbSettingIsDisposeDbCommandAfterExecuteReaderProperty()
        {
            // Setup
            var setting = DbSettingMapper.Get<SQLiteConnection>();

            // Assert
            Assert.IsTrue(setting.IsDisposeDbCommandAfterExecuteReader);
        }

        [TestMethod]
        public void TestSqLiteDbSettingIsMultipleStatementExecutionSupportedProperty()
        {
            // Setup
            var setting = DbSettingMapper.Get<SQLiteConnection>();

            // Assert
            Assert.IsTrue(setting.IsMultipleStatementExecutionSupported);
        }

        [TestMethod]
        public void TestSqLiteDbSettingIsUseUpsertForMergeOperationProperty()
        {
            // Setup
            var setting = DbSettingMapper.Get<SQLiteConnection>();

            // Assert
            Assert.IsFalse(setting.IsUseUpsertForMergeOperation);
        }

        [TestMethod]
        public void TestSqLiteDbSettingOpeningQuoteProperty()
        {
            // Setup
            var setting = DbSettingMapper.Get<SQLiteConnection>();

            // Assert
            Assert.AreEqual("[", setting.OpeningQuote);
        }

        [TestMethod]
        public void TestSqLiteDbSettingParameterPrefixProperty()
        {
            // Setup
            var setting = DbSettingMapper.Get<SQLiteConnection>();

            // Assert
            Assert.AreEqual("@", setting.ParameterPrefix);
        }

        [TestMethod]
        public void TestSqLiteDbSettingSchemaSeparatorProperty()
        {
            // Setup
            var setting = DbSettingMapper.Get<SQLiteConnection>();

            // Assert
            Assert.AreEqual(".", setting.SchemaSeparator);
        }
    }
}

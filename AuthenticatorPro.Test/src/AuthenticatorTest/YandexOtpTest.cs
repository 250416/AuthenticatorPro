// Copyright (C) 2022 jmh
// SPDX-License-Identifier: GPL-3.0-only

// Test data from https://github.com/norblik/KeeYaOtp
// Licensed under GPL 3.0

using AuthenticatorPro.Shared.Data.Generator;
using Xunit;

namespace AuthenticatorPro.Test.AuthenticatorTest
{
    public class YandexOtpTest
    {
        [Theory]
        [InlineData("LA2V6KMCGYMWWVEW64RNP3JA3IAAAAAAHTSG4HRZPI", "7586", 1581064020, "oactmacq")]
        [InlineData("LA2V6KMCGYMWWVEW64RNP3JA3IAAAAAAHTSG4HRZPI", "7586", 1581090810, "wemdwrix")]
        [InlineData("JBGSAU4G7IEZG6OY4UAXX62JU4AAAAAAHTSG4HXU3M", "5210481216086702", 1581091469, "dfrpywob")]
        [InlineData("JBGSAU4G7IEZG6OY4UAXX62JU4AAAAAAHTSG4HXU3M", "5210481216086702", 1581093059, "vunyprpd")]
        public void ComputeTest(string secret, string pin, long offset, string expectedResult)
        {
            var yandexOtp = new YandexOtp(secret, pin);
            Assert.Equal(expectedResult, yandexOtp.Compute(offset));
        }
    }
}
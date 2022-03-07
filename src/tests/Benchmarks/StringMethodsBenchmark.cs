using BenchmarkDotNet.Attributes;
using Perfolizer.Mathematics.OutlierDetection;
using System;
using ValidatorLib;
using ValidatorLib.Validators;

namespace Benchmarks
{
    [Outliers(OutlierMode.DontRemove)]
    public class StringMethodsBenchmark
    {
        [Benchmark]
        public void IsEmailAddress()
        {
            Validator.Validate("asd@asd.com").IsEmailAddress();
        }

        [Benchmark]
        public void IsEmailAddressException()
        {
            try
            {
                Validator.Validate("asdasd.com").IsEmailAddress();
            }
            catch (Exception)
            {
            }
        }

        [Benchmark]
        public void IsPhoneNumber()
        {
            Validator.Validate("123456789").IsPhoneNumber();
        }

        [Benchmark]
        public void IsPhoneNumberException()
        {
            try
            {
                Validator.Validate("a").IsPhoneNumber();
            }
            catch (Exception)
            {
            }
        }
    }
}

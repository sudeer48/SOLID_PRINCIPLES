using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES
{
    public class LiskovSubstitutionPrinciple
    {

    }

    //Below are the regular form of declarations.

    //public class SumCalculator
    //{
    //    protected readonly int[] _numbers;

    //    public SumCalculator(int[] numbers)
    //    {
    //        _numbers = numbers;
    //    }

    //    public int Calculate() => _numbers.Sum();
    //}

    //public class EvenNumbersSumCalculator : SumCalculator
    //{
    //    public EvenNumbersSumCalculator(int[] numbers)
    //        : base(numbers)
    //    {
    //    }

    //    public new int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    //}

    public abstract class Calculator
    {
        protected readonly int[] _numbers;

        public Calculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public abstract int Calculate();
    }

    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers)
            : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Sum();
    }

    public class EvenNumbersSumCalculator : Calculator
    {
        public EvenNumbersSumCalculator(int[] numbers)
           : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}

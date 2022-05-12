using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class InchConverter {
        private const double ratio = 0.0254;

        //インチからメートルへ
        public static double FromInch(int inch) {
            return inch * ratio;
        }

        //メートルからインチへ
        public static double ToInch(double mater) {
            return mater / ratio;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class evaluare
    {
        public int[][] m = new int[4][];
        public evaluare (int [][] a)
        {
            m[1] = new int[4];
            m[2] = new int[4];
            m[3] = new int[4];
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 3; j++)
                    if (a[i][j] == 1 || a[i][j] == 2)
                        m[i][j] = a[i][j];
                    else
                        m[i][j] = 0;
        }
        public bool p()
        {
            for (int i = 1; i <= 3; i++)
                if (m[i][1] == m[i][2] && m[i][1] == m[i][3] && m[i][1]!=0)
                    return true;
                else
                if (m[1][i] == m[2][i] && m[1][i] == m[3][i] && m[1][i] != 0)
                    return true;
            if (m[1][1] == m[2][2] && m[1][1] == m[3][3] && m[1][1] != 0)
                return true;
            if(m[1][3] == m[2][2] && m[1][3] == m[3][1] && m[3][1] != 0)
                return true;
            return false;
        }
        public bool rem()
        {
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 3; j++)
                    if (m[i][j] == 0)
                        return false;
            return true;
        }
        public int ras()
        {
            if (p() == true)
                return 1;
            else
                if (rem() == true)
                return 2;
            else
                return 0;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DianTaxesAndInvoicesApp.Files
{
    internal class FileContent
    {

       private static string[] Invoices = new string[]
        {
            "FA001;10000;1900;11900;Enero;SI",
            "FA002;20500;3895;24395;Julio;SI",
            "FA003;120000;22800;142800;Diciembre;SI",
            "FA004;458000;87020;545020;Diciembre;SI",
            "FA005;26000;4940;30940;Diciembre;SI",
            "FA006;35000;6650;41650;Diciembre;SI",
            "FA007;456900;86811;543711;Diciembre;SI",
            "FA008;78000;14820;92820;Julio;SI",
            "FA009;97000;18430;115430;Julio;SI",
            "FA010;108900;20691;129591;Julio;SI",
            "FA011;2963790;563120,1;3526910,1;Enero;NO",
            "FA012;1622811;308334,09;1931145,09;Enero;NO",
            "FA013;1962394;372854,86;2335248,86;Enero;SI",
            "FA014;2950942;560678,98;3511620,98;Agosto;SI",
            "FA015;3572660;678805,4;4251465,4;Agosto;SI",
            "FA016;3464394;658234,86;4122628,86;Agosto;SI",
            "FA017;3948860;750283,4;4699143,4;Febrero;SI",
            "FA018;2816262;535089,78;3351351,78;Agosto;SI",
            "FA019;1750681;332629,39;2083310,39;Agosto;NO",
            "FA020;1867059;354741,21;2221800,21;Agosto;NO",
            "FA021;2788905;529891,95;3318796,95;Febrero;SI",
            "FA022;3038502;577315,38;3615817,38;Septiembre;SI",
            "FA023;752476;142970,44;895446,44;Noviembre;SI",
            "FA024;2081316;395450,04;2476766,04;Noviembre;SI",
            "FA025;1331836;253048,84;1584884,84;Noviembre;NO",
            "FA026;4286809;814493,71;5101302,71;Noviembre;NO",
            "FA027;3744576;711469,44;4456045,44;Noviembre;SI",
            "FA028;1381975;262575,25;1644550,25;Noviembre;SI",
            "FA029;3034673;576587,87;3611260,87;Febrero;SI",
            "FA030;658350;125086,5;783436,5;Febrero;SI"
        };

        public static string[] GetInvoices()
        {
            return Invoices;
        }
    }
}

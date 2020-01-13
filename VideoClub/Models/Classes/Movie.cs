using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace VideoClub.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        [StringLength(25)]
        public string Title { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public int Lenght { get; set; }

        
        public MovieLanguage MovieLanguage { get; set; }

        public CountryOFProduction ContryOfProduction { get; set; }     // Dropdown when the movie is being added

        public Genre Genre { get; set; }

        // Navigation

        public virtual ICollection <MovieCast> MovieCasts { get; set; }


    }


    public enum MovieLanguage
    {
        EN,
        PT,
        PL,
        ES,
        FR
    }

    public enum Genre
    {
        Action,
        Comedy,
        Adventure,
        Romance,
        Horror,
        Thriller,
        Animation
    }



    public enum CountryOFProduction
    {

        
        AF,
        AL,
        DZ,
        AS,
        AD,
        AO,
        AI,
        AQ,
        AG,
        AR,
        AM,
        AW,
        AU,
        AT,
        AZ,
        BS,
        BH,
        BD,
        BB,
        BY,
        BE,
        BZ,
        BJ,
        BM,
        BT,
        BO,
        BA,
        BW,
        BV,
        BR,
        IO,
        BN,
        BG,
        BF,
        BI,
        KH,
        CM,
        CA,
        CV,
        KY,
        CF,
        TD,
        CL,
        CN,
        CX,
        CC,
        CO,
        KM,
        CG,
        CD,
        CK,
        CR,
        CI,
        HR,
        CU,
        CY,
        CZ,
        DK,
        DJ,
        DM,
        DO,
        EC,
        EG, 
        EH,
        SV,
        GQ,
        ER,
        EE,
        ET,
        FK, 
        FO,
        FJ,
        FI,
        FR,
        GF,
        PF,
        TF,
        GA,
        GM,
        GE,
        DE,
        GH,
        GI,
        GR,
        GL,
        GD,
        GP,
        GU,
        GT,
        GN,
        GW,
        GY,
        HT,
        HM,
        HN, 
        HK,
        HU,
        IS,
        IN,
        ID,
        IR,
        IQ,
        IE,
        IL,
        IT ,
        JM , 
        JP,
        JO, 
        KZ,
        KE,
        KI,  
        KP, 
        KR, 
        KW,
        KG, 
        LA, 
        LV, 
        LB, 
        LS,
        LR,
        LY,
        LI,
        LT,
        LU,
        MO,
        MK,
        MG,
        MW,
        MY, 
        MV, 
        ML,
        MT,
        MH,
        MQ,
        MR,
        MU, 
        YT, 
        MX, 
        FM,
        MD,
        MC,
        MN,
        MS,
        MA,
        MZ,
        MM,
        NA,
        NR,
        NP,
        NL,
        AN,
        NC,
        NI,
        NE,
        NG,
        NU,
        MP,
        NO,
        OM,
        PK,
        PW,
        PS,
        PA,
        PG,
        PY, 
        PE,
        PH,
        PL,
        PT,
        PR,
        RE,
        RO, 
        RU, 
        RW,
        SH,
        LC,
        PM, 
        VC, 
        WS, 
        SK, 
        SI, 
        ZA, 
        GS, 
        SD, 
        SR,
        SE,
        SY, 
        TW, 
        TJ, 
        TZ, 
        TH, 
        TL, 
        TG, 
        TK,
        TO, 
        TT,
        TR,
        TM, 
        TC,
        TV,
        UG,
        UA,
        AE,
        GB,
        US,
        UM,
        UY,
        UZ,
        VE,
        VU,
        VN,
        VG,
        WF,
        ZW


    }



}

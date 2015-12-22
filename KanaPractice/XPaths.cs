﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanaPractice {

    /// <summary>
    /// A Class to hold Strings 
    /// of Each XPath Element 
    /// Based on what Kana the user 
    /// wants to practice.
    /// </summary>
    public static class XPaths {
        
        public struct aiueo {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;
            public void init() {
                hirg = new string[] {
                    "/kana/hirg/aiueo/a",
                    "/kana/hirg/aiueo/i",
                    "/kana/hirg/aiueo/u",
                    "/kana/hirg/aiueo/e",
                    "/kana/hirg/aiueo/o"
                }; //0-4

                kata = new string[] {
                    "/kana/kata/aiueo/a",
                    "/kana/kata/aiueo/i",
                    "/kana/kata/aiueo/u",
                    "/kana/kata/aiueo/e",
                    "/kana/kata/aiueo/o"
                }; //0-4

                mixed = new string[] {
                    "/kana/hirg/aiueo/a","/kana/kata/aiueo/a",
                    "/kana/hirg/aiueo/i","/kana/kata/aiueo/i",
                    "/kana/hirg/aiueo/u","/kana/kata/aiueo/u",
                    "/kana/hirg/aiueo/e","/kana/kata/aiueo/e",
                    "/kana/hirg/aiueo/o","/kana/kata/aiueo/o"
                }; //0-9
            } //End Init
        } //End Struct


        #region K/G
        public struct kSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                //aiueo
                hirg = new string[] {
                    "/kana/hirg/kSeries/ka",
                    "/kana/hirg/kSeries/ki",
                    "/kana/hirg/kSeries/ku",
                    "/kana/hirg/kSeries/ke",
                    "/kana/hirg/kSeries/ko"
                }; //0-4

                kata = new string[] {
                    "/kana/kata/kSeries/ka",
                    "/kana/kata/kSeries/ki",
                    "/kana/kata/kSeries/ku",
                    "/kana/kata/kSeries/ke",
                    "/kana/kata/kSeries/ko"
                }; //0-4

                mixed = new string[] {
                    "/kana/hirg/kSeries/ka","/kana/kata/kSeries/ka",
                    "/kana/hirg/kSeries/ki","/kana/kata/kSeries/ki",
                    "/kana/hirg/kSeries/ku","/kana/kata/kSeries/ku",
                    "/kana/hirg/kSeries/ke","/kana/kata/kSeries/ke",
                    "/kana/hirg/kSeries/ko","/kana/kata/kSeries/ko"
                }; //0-9
            } //End Init
        } //End Struct kSeries

        public struct gSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/gSeries/ga",
                    "/kana/hirg/gSeries/gi",
                    "/kana/hirg/gSeries/gu",
                    "/kana/hirg/gSeries/ge",
                    "/kana/hirg/gSeries/go"
                }; //0-4

                kata = new string[] {
                    "/kana/kata/gSeries/ga",
                    "/kana/kata/gSeries/gi",
                    "/kana/kata/gSeries/gu",
                    "/kana/kata/gSeries/ge",
                    "/kana/kata/gSeries/go"
                }; //0-4

                mixed = new string[] {
                    "/kana/hirg/gSeries/ga","/kana/kata/gSeries/ga",
                    "/kana/hirg/gSeries/gi","/kana/kata/gSeries/gi",
                    "/kana/hirg/gSeries/gu","/kana/kata/gSeries/gu",
                    "/kana/hirg/gSeries/ge","/kana/kata/gSeries/ge",
                    "/kana/hirg/gSeries/go","/kana/kata/gSeries/go"
                }; // 0-9
            } //end Init
        } //End Struct gSeries

        public struct comboK {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/comboK/kya",
                    "/kana/hirg/comboK/kyu",
                    "/kana/hirg/comboK/kyo"
                }; //0-2

                kata = new string[] {
                    "/kana/kata/comboK/kya",
                    "/kana/kata/comboK/kyu",
                    "/kana/kata/comboK/kyo"
                }; //0-2

                mixed = new string[] {
                    "/kana/hirg/comboK/kya","/kana/kata/comboK/kya",
                    "/kana/hirg/comboK/kyu","/kana/kata/comboK/kyu",
                    "/kana/hirg/comboK/kyo","/kana/kata/comboK/kyo"
                }; //0-5


            } //End Init
        } //End Struct comboK

        public struct comboG {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/comboG/gya",
                    "/kana/hirg/comboG/gyu",
                    "/kana/hirg/comboG/gyo"
                }; //0-2

                kata = new string[] {
                    "/kana/kata/comboG/gya",
                    "/kana/kata/comboG/gyu",
                    "/kana/kata/comboG/gyo"
                }; //0-2

                mixed = new string[] {
                    "/kana/hirg/comboG/gya","/kana/kata/comboG/gya",
                    "/kana/hirg/comboG/gyu","kana/kata/comboG/gyu",
                    "/kana/hirg/comboG/gyo","/kana/kata/comboG/gyo"
                };
            } //End Init
        } //End Struct comboG
        #endregion

        #region S/Z
        public struct sSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/sSeries/sa",
                    "/kana/hirg/sSeries/shi",
                    "/kana/hirg/sSeries/su",
                    "/kana/hirg/sSeries/se",
                    "/kana/hirg/sSeries/so"
                };

                kata = new string[] {
                    "/kana/kata/sSeries/sa",
                    "/kana/kata/sSeries/shi",
                    "/kana/kata/sSeries/su",
                    "/kana/kata/sSeries/se",
                    "/kana/kata/sSeries/so"
                };

                mixed = new string[] {
                    "/kana/hirg/sSeries/sa","/kana/kata/sSeries/sa",
                    "/kana/hirg/sSeries/shi","/kana/kata/sSeries/shi",
                    "/kana/hirg/sSeries/su","/kana/kata/sSeries/su",
                    "/kana/hirg/sSeries/se","/kana/kata/sSeries/se",
                    ""
                };
            } //end Init
        } //end Struct sSeries

        public struct zSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/zSeries/za",
                    "/kana/hirg/zSeries/ji",
                    "/kana/hirg/zSeries/zu",
                    "/kana/hirg/zSeries/ze",
                    "/kana/hirg/zSeries/zo"
                };

                kata = new string[] {
                    "/kana/kata/zSeries/za",
                    "/kana/kata/zSeries/ji",
                    "/kana/kata/zSeries/zu",
                    "/kana/kata/zSeries/ze",
                    "/kana/kata/zSeries/zo"
                };

                mixed = new string[] {
                    "/kana/hirg/zSeries/za","/kana/kata/zSeries/za",
                    "/kana/hirg/zSeries/ji","/kana/kata/zSeries/ji",
                    "/kana/hirg/zSeries/zu","/kana/kata/zSeries/zu",
                    "/kana/hirg/zSeries/ze","/kana/kata/zSeries/ze",
                    "/kana/hirg/zSeries/zo","/kana/kata/zSeries/zo"
                };

            } //End init()
        } //End Struct zSeries

        public struct comboS {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/comboS/sha",
                    "/kana/hirg/comboS/shu",
                    "/kana/hirg/comboS/sho"
                };

                kata = new string[] {
                    "/kana/kata/comboS/sha",
                    "/kana/kata/comboS/shu",
                    "/kana/kata/comboS/sho"
                };

                mixed = new string[] {
                    "/kana/hirg/comboS/sha","/kana/kata/comboS/sha",
                    "/kana/hirg/comboS/shu","/kana/kata/comboS/shu",
                    "/kana/hirg/comboS/sho","/kana/kata/comboS/sho"
                };
            }//End Init
        } //End Struct comboS

        public struct comboJ {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {

                hirg = new string[] {
                    "/kana/hirg/comboJ/ja",
                    "/kana/hirg/comboJ/ju",
                    "/kana/hirg/comboJ/jo"
                };

                kata = new string[] {
                    "/kana/kata/comboJ/ja",
                    "/kana/kata/comboJ/ju",
                    "/kana/kata/comboJ/jo"
                };

                mixed = new string[] {
                    "/kana/hirg/comboJ/ja","/kana/kata/comboJ/ja",
                    "/kana/hirg/comboJ/ju","/kana/kata/comboJ/ju",
                    "/kana/hirg/comboJ/jo","/kana/kata/comboJ/jo"
                };
            }//End Init
        } //End Struct comboJ
        #endregion

        #region T/D
        public struct tSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/tSeries/ta",
                    "/kana/hirg/tSeries/chi",
                    "/kana/hirg/tSeries/tsu",
                    "/kana/hirg/tSeries/te",
                    "/kana/hirg/tSeries/to"
                };

                kata = new string[] {
                    "/kana/kata/tSeries/ta",
                    "/kana/kata/tSeries/chi",
                    "/kana/kata/tSeries/tsu",
                    "/kana/kata/tSeries/te",
                    "/kana/kata/tSeries/to"
                };

                mixed = new string[] {
                    "/kana/hirg/tSeries/ta","/kana/kata/tSeries/ta",
                    "/kana/hirg/tSeries/chi","/kana/kata/tSeries/chi",
                    "/kana/hirg/tSeries/tsu","/kana/kata/tSeries/tsu",
                    "/kana/hirg/tSeries/te","/kana/kata/tSeries/te",
                    "/kana/hirg/tSeries/to","/kana/kata/tSeries/to"
                };
            } //End Init
        } //End struct tSeries

        public struct dSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/dSeries/da",
                    "/kana/hirg/dSeries/di",
                    "/kana/hirg/dSeries/du",
                    "/kana/hirg/dSeries/de",
                    "/kana/hirg/dSeries/do"
                };

                kata = new string[] {
                    "/kana/kata/dSeries/da",
                    "/kana/kata/dSeries/di",
                    "/kana/kata/dSeries/du",
                    "/kana/kata/dSeries/de",
                    "/kana/kata/dSeries/do"
                };

                mixed = new string[] {
                    "/kana/hirg/dSeries/da","/kana/kata/dSeries/da",
                    "/kana/hirg/dSeries/di","/kana/kata/dSeries/di",
                    "/kana/hirg/dSeries/du","/kana/kata/dSeries/du",
                    "/kana/hirg/dSeries/de","/kana/kata/dSeries/de",
                    "/kana/hirg/dSeries/do","/kana/kata/dSeries/do"
                };
            } //End Init
        } //End Struct dSeries

        public struct comboCH {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/comboCH/cha",
                    "/kana/hirg/comboCH/chu",
                    "/kana/hirg/comboCH/cho"
                };

                kata = new string[] {
                    "/kana/kata/comboCH/cha",
                    "/kana/kata/comboCH/chu",
                    "/kana/kata/comboCH/cho"
                };

                mixed = new string[] {
                    "/kana/hirg/comboCH/cha","/kana/kata/comboCH/cha",
                    "/kana/hirg/comboCH/chu","/kana/kata/comboCH/chu",
                    "/kana/hirg/comboCH/cho","/kana/kata/comboCH/cho"
                };
            }//End Init
        } //End Struct comboCH

        public struct comboD {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/comboD/dya",
                    "/kana/hirg/comboD/dyu",
                    "/kana/hirg/comboD/dyo"
                };

                kata = new string[] {
                    "/kana/kata/comboD/dya",
                    "/kana/kata/comboD/dyu",
                    "/kana/kata/comboD/dyo"
                };

                mixed = new string[] {
                    "/kana/hirg/comboD/dya","/kana/kata/comboD/dya",
                    "/kana/hirg/comboD/dyu","/kana/kata/comboD/dyu",
                    "/kana/hirg/comboD/dyo","/kana/kata/comboD/dyo"
                };

            }//End Init 
        }//End Struct comboD
        #endregion

        #region N
        public struct nSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/nSeries/na",
                    "/kana/hirg/nSeries/ni",
                    "/kana/hirg/nSeries/nu",
                    "/kana/hirg/nSeries/ne",
                    "/kana/hirg/nSeries/no"
                };

                kata = new string[] {
                    "/kana/kata/nSeries/na",
                    "/kana/kata/nSeries/ni",
                    "/kana/kata/nSeries/nu",
                    "/kana/kata/nSeries/ne",
                    "/kana/kata/nSeries/no"
                };

                mixed = new string[] {
                    "/kana/hirg/nSeries/na","/kana/kata/nSeries/na",
                    "/kana/hirg/nSeries/ni","/kana/kata/nSeries/ni",
                    "/kana/hirg/nSeries/nu","/kana/kata/nSeries/nu",
                    "/kana/hirg/nSeries/ne","/kana/kata/nSeries/ne",
                    "/kana/hirg/nSeries/no","/kana/kata/nSeries/no"
                };

            }//End Init

        } 

        public struct comboN {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/comboN/nya",
                    "/kana/hirg/comboN/nyu",
                    "/kana/hirg/comboN/nyo"
                };

                kata = new string[] {
                    "/kana/kata/comboN/nya",
                    "/kana/kata/comboN/nyu",
                    "/kana/kata/comboN/nyo"
                };

                mixed = new string[] {
                    "/kana/hirg/comboN/nya","/kana/kata/comboN/nya",
                    "/kana/hirg/comboN/nyu","/kana/kata/comboN/nyu",
                    "/kana/hirg/comboN/nyo","/kana/kata/comboN/nyo"
                };
            } //End init
        } //End Struct

        #endregion

        #region H/B/P
        public struct hSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/hSeries/ha",
                    "/kana/hirg/hSeries/hi",
                    "/kana/hirg/hSeries/fu",
                    "/kana/hirg/hSeries/he",
                    "/kana/hirg/hSeries/ho"
                };

                kata = new string[] {
                    "/kana/kata/hSeries/ha",
                    "/kana/kata/hSeries/hi",
                    "/kana/kata/hSeries/fu",
                    "/kana/kata/hSeries/he",
                    "/kana/kata/hSeries/ho"
                };

                mixed = new string[] {
                    "/kana/hirg/hSeries/ha","/kana/kata/hSeries/ha",
                    "/kana/hirg/hSeries/hi","/kana/kata/hSeries/hi",
                    "/kana/hirg/hSeries/fu","/kana/kata/hSeries/fu",
                    "/kana/hirg/hSeries/he","/kana/kata/hSeries/he",
                    "/kana/hirg/hSeries/ho","/kana/kata/hSeries/ho"
                };
            } //End Init
        } //End Structure hSeries

        public struct bSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/bSeries/ba",
                    "/kana/hirg/bSeries/bi",
                    "/kana/hirg/bSeries/bu",
                    "/kana/hirg/bSeries/be",
                    "/kana/hirg/bSeries/bo"
                };

                kata = new string[] {
                    "/kana/kata/bSeries/ba",
                    "/kana/kata/bSeries/bi",
                    "/kana/kata/bSeries/bu",
                    "/kana/kata/bSeries/be",
                    "/kana/kata/bSeries/bo"
                };

                mixed = new string[] {
                    "/kana/hirg/bSeries/ba","/kana/kata/bSeries/ba",
                    "/kana/hirg/bSeries/bi","/kana/kata/bSeries/bi",
                    "/kana/hirg/bSeries/bu","/kana/kata/bSeries/bu",
                    "/kana/hirg/bSeries/be","/kana/kata/bSeries/be",
                    "/kana/hirg/bSeries/bo","/kana/kata/bSeries/bo"
                };
            } //End Init()

        } //End Structure bSeries

        public struct pSeries {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/pSeries/pa",
                    "/kana/hirg/pSeries/pi",
                    "/kana/hirg/pSeries/pu",
                    "/kana/hirg/pSeries/pe",
                    "/kana/hirg/pSeries/po"
                };

                kata = new string[] {
                    "/kana/kata/pSeries/pa",
                    "/kana/kata/pSeries/pi",
                    "/kana/kata/pSeries/pu",
                    "/kana/kata/pSeries/pe",
                    "/kana/kata/pSeries/po"
                };

                mixed = new string[] {
                    "/kana/hirg/pSeries/pa","/kana/kata/pSeries/pa",
                    "/kana/hirg/pSeries/pi","/kana/kata/pSeries/pi",
                    "/kana/hirg/pSeries/pu","/kana/kata/pSeries/pu",
                    "/kana/hirg/pSeries/pe","/kana/kata/pSeries/pe",
                    "/kana/hirg/pSeries/po","/kana/kata/pSeries/po"
                };
            }//End Init

        } //End Structure pSeries

        public struct comboH {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/comboH/hya",
                    "/kana/hirg/comboH/hyu",
                    "/kana/hirg/comboH/hyo"
                };

                kata = new string[] {
                    "/kana/kata/comboH/hya",
                    "/kana/kata/comboH/hyu",
                    "/kana/kata/comboH/hyo"
                };

                mixed = new string[] {
                    "/kana/hirg/comboH/hya","/kana/kata/comboH/hya",
                    "/kana/hirg/comboH/hyu","/kana/kata/comboH/hyu",
                    "/kana/hirg/comboH/hyo","/kana/kata/comboH/hyo"
                };
            } //End INit
        } //End Struct

        public struct comboB {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/comboB/bya",
                    "/kana/hirg/comboB/byu",
                    "/kana/hirg/comboB/byo"
                };

                kata = new string[] {
                    "/kana/kata/comboB/bya",
                    "/kana/kata/comboB/byu",
                    "/kana/kata/comboB/byo"
                };

                mixed = new string[] {
                    "/kana/hirg/comboB/bya","/kana/kata/comboB/bya",
                    "/kana/hirg/comboB/byu","/kana/kata/comboB/byu",
                    "/kana/hirg/comboB/byo","/kana/kata/comboB/byo"
                };
            } //End Init
        } //End Struct

        public struct comboP {
            public string[] hirg;
            public string[] kata;
            public string[] mixed;

            public void init() {
                hirg = new string[] {
                    "/kana/hirg/comboP/pya",
                    "/kana/hirg/comboP/pyu",
                    "/kana/hirg/comboP/pyo"
                };

                kata = new string[] {
                    "/kana/kata/comboP/pya",
                    "/kana/kata/comboP/pyu",
                    "/kana/kata/comboP/pyo"
                };

                mixed = new string[] {
                    "/kana/hirg/comboP/pya","/kana/kata/comboP/pya",
                    "/kana/hirg/comboP/pyu","/kana/kata/comboP/pyu",
                    "/kana/hirg/comboP/pyo","/kana/kata/comboP/pyo"
                };

            } //End Init
        }//End Struct
        #endregion





    }
}

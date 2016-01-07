﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Core //1:1
{
    using __Hidden_MetaModelJavaGenerator_1889302984;
    namespace __Hidden_MetaModelJavaGenerator_1889302984
    {
        internal static class __Extensions
        {
            internal static IEnumerator<T> GetEnumerator<T>(this T item)
            {
                if (item == null) return new List<T>().GetEnumerator();
                else return new List<T> { item }.GetEnumerator();
            }
        }
    }

    public class MetaModelJavaGenerator //2:1
    {
        private IEnumerable<ModelObject> Instances; //2:1

        public MetaModelJavaGenerator() //2:1
        {
            this.Properties = new __Properties();
        }

        public MetaModelJavaGenerator(IEnumerable<ModelObject> instances) : this() //2:1
        {
            this.Instances = instances;
        }

        private Stream __ToStream(string text)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(text);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        private static IEnumerable<T> __Enumerate<T>(IEnumerator<T> items)
        {
            while (items.MoveNext())
            {
                yield return items.Current;
            }
        }

        private int counter = 0;
        private int NextCounter()
        {
            return ++counter;
        }

        public __Properties Properties { get; private set; } //4:1

        public class __Properties //4:1
        {
            internal __Properties()
            {
                this.LineCount = 0; //5:18
                this.FunctionCount = 0; //6:22
            }
            public int LineCount { get; set; } //5:2
            public int FunctionCount { get; set; } //6:2
        }

        public string Generate() //9:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop1_results = 
                (from __loop1_var1 in __Enumerate((Instances).GetEnumerator()) //10:8
                from mm in __Enumerate((__loop1_var1).GetEnumerator()).OfType<MetaModel>() //10:19
                select new { __loop1_var1 = __loop1_var1, mm = mm}
                ).ToList(); //10:3
            int __loop1_iteration = 0;
            foreach (var __tmp1 in __loop1_results)
            {
                ++__loop1_iteration;
                var __loop1_var1 = __tmp1.__loop1_var1;
                var mm = __tmp1.mm;
                string __tmp2Prefix = string.Empty;
                string __tmp3Suffix = string.Empty;
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(GenerateMetamodel(mm));
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //11:24
                    }
                }
            }
            return __out.ToString();
        }

        public string ResetCounters() //15:1
        {
            Properties.LineCount = 0; //16:2
            Properties.FunctionCount = 0; //17:2
            return ""; //18:2
        }

        public string GenerateMetamodel(MetaModel model) //21:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty;
            string __tmp2Suffix = string.Empty;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GenerateMetaModelDescriptor(model));
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //22:37
                }
            }
            string __tmp4Prefix = string.Empty;
            string __tmp5Suffix = string.Empty;
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateMetaModelInstance(model));
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //23:35
                }
            }
            var __loop2_results = 
                (from __loop2_var1 in __Enumerate((model).GetEnumerator()) //24:7
                from Namespace in __Enumerate((__loop2_var1.Namespace).GetEnumerator()) //24:14
                from Declarations in __Enumerate((Namespace.Declarations).GetEnumerator()) //24:25
                from enm in __Enumerate((Declarations).GetEnumerator()).OfType<MetaEnum>() //24:39
                select new { __loop2_var1 = __loop2_var1, Namespace = Namespace, Declarations = Declarations, enm = enm}
                ).ToList(); //24:2
            int __loop2_iteration = 0;
            foreach (var __tmp7 in __loop2_results)
            {
                ++__loop2_iteration;
                var __loop2_var1 = __tmp7.__loop2_var1;
                var Namespace = __tmp7.Namespace;
                var Declarations = __tmp7.Declarations;
                var enm = __tmp7.enm;
                string __tmp8Prefix = string.Empty;
                string __tmp9Suffix = string.Empty;
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(GenerateEnum(enm));
                using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
                {
                    bool __tmp10_first = true;
                    while(__tmp10_first || !__tmp10Reader.EndOfStream)
                    {
                        __tmp10_first = false;
                        string __tmp10Line = __tmp10Reader.ReadLine();
                        if (__tmp10Line == null)
                        {
                            __tmp10Line = "";
                        }
                        __out.Append(__tmp8Prefix);
                        __out.Append(__tmp10Line);
                        __out.Append(__tmp9Suffix);
                        __out.AppendLine(); //25:20
                    }
                }
            }
            var __loop3_results = 
                (from __loop3_var1 in __Enumerate((model).GetEnumerator()) //27:7
                from Namespace in __Enumerate((__loop3_var1.Namespace).GetEnumerator()) //27:14
                from Declarations in __Enumerate((Namespace.Declarations).GetEnumerator()) //27:25
                from cls in __Enumerate((Declarations).GetEnumerator()).OfType<MetaClass>() //27:39
                select new { __loop3_var1 = __loop3_var1, Namespace = Namespace, Declarations = Declarations, cls = cls}
                ).ToList(); //27:2
            int __loop3_iteration = 0;
            foreach (var __tmp11 in __loop3_results)
            {
                ++__loop3_iteration;
                var __loop3_var1 = __tmp11.__loop3_var1;
                var Namespace = __tmp11.Namespace;
                var Declarations = __tmp11.Declarations;
                var cls = __tmp11.cls;
                string __tmp12Prefix = string.Empty;
                string __tmp13Suffix = string.Empty;
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(GenerateInterface(cls));
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_first = true;
                    while(__tmp14_first || !__tmp14Reader.EndOfStream)
                    {
                        __tmp14_first = false;
                        string __tmp14Line = __tmp14Reader.ReadLine();
                        if (__tmp14Line == null)
                        {
                            __tmp14Line = "";
                        }
                        __out.Append(__tmp12Prefix);
                        __out.Append(__tmp14Line);
                        __out.Append(__tmp13Suffix);
                        __out.AppendLine(); //28:25
                    }
                }
                string __tmp15Prefix = string.Empty;
                string __tmp16Suffix = string.Empty;
                StringBuilder __tmp17 = new StringBuilder();
                __tmp17.Append(GenerateInterfaceImpl(model, cls));
                using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
                {
                    bool __tmp17_first = true;
                    while(__tmp17_first || !__tmp17Reader.EndOfStream)
                    {
                        __tmp17_first = false;
                        string __tmp17Line = __tmp17Reader.ReadLine();
                        if (__tmp17Line == null)
                        {
                            __tmp17Line = "";
                        }
                        __out.Append(__tmp15Prefix);
                        __out.Append(__tmp17Line);
                        __out.Append(__tmp16Suffix);
                        __out.AppendLine(); //29:36
                    }
                }
            }
            string __tmp18Prefix = string.Empty;
            string __tmp19Suffix = string.Empty;
            StringBuilder __tmp20 = new StringBuilder();
            __tmp20.Append(GenerateFactory(model));
            using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
            {
                bool __tmp20_first = true;
                while(__tmp20_first || !__tmp20Reader.EndOfStream)
                {
                    __tmp20_first = false;
                    string __tmp20Line = __tmp20Reader.ReadLine();
                    if (__tmp20Line == null)
                    {
                        __tmp20Line = "";
                    }
                    __out.Append(__tmp18Prefix);
                    __out.Append(__tmp20Line);
                    __out.Append(__tmp19Suffix);
                    __out.AppendLine(); //31:25
                }
            }
            string __tmp21Prefix = string.Empty;
            string __tmp22Suffix = string.Empty;
            StringBuilder __tmp23 = new StringBuilder();
            __tmp23.Append(GenerateImplementationProvider(model));
            using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
            {
                bool __tmp23_first = true;
                while(__tmp23_first || !__tmp23Reader.EndOfStream)
                {
                    __tmp23_first = false;
                    string __tmp23Line = __tmp23Reader.ReadLine();
                    if (__tmp23Line == null)
                    {
                        __tmp23Line = "";
                    }
                    __out.Append(__tmp21Prefix);
                    __out.Append(__tmp23Line);
                    __out.Append(__tmp22Suffix);
                    __out.AppendLine(); //32:40
                }
            }
            string __tmp24Prefix = string.Empty;
            string __tmp25Suffix = string.Empty;
            StringBuilder __tmp26 = new StringBuilder();
            __tmp26.Append(GenerateImplementationBase(model));
            using(StreamReader __tmp26Reader = new StreamReader(this.__ToStream(__tmp26.ToString())))
            {
                bool __tmp26_first = true;
                while(__tmp26_first || !__tmp26Reader.EndOfStream)
                {
                    __tmp26_first = false;
                    string __tmp26Line = __tmp26Reader.ReadLine();
                    if (__tmp26Line == null)
                    {
                        __tmp26Line = "";
                    }
                    __out.Append(__tmp24Prefix);
                    __out.Append(__tmp26Line);
                    __out.Append(__tmp25Suffix);
                    __out.AppendLine(); //33:36
                }
            }
            return __out.ToString();
        }

        public string GenerateAnnotations(MetaAnnotatedElement elem) //36:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop4_results = 
                (from __loop4_var1 in __Enumerate((elem).GetEnumerator()) //37:7
                from annot in __Enumerate((__loop4_var1.Annotations).GetEnumerator()) //37:13
                select new { __loop4_var1 = __loop4_var1, annot = annot}
                ).ToList(); //37:2
            int __loop4_iteration = 0;
            foreach (var __tmp1 in __loop4_results)
            {
                ++__loop4_iteration;
                var __loop4_var1 = __tmp1.__loop4_var1;
                var annot = __tmp1.annot;
                string __tmp2Prefix = "@"; //38:1
                string __tmp3Suffix = string.Empty; 
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(annot.Name);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                        __out.Append(__tmp3Suffix);
                        __out.AppendLine(); //38:14
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateEnum(MetaEnum enm) //42:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //43:1
            string __tmp2Suffix = ";"; //43:35
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(enm.Namespace.JavaName());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //43:36
                }
            }
            __out.AppendLine(); //44:1
            string __tmp4Prefix = string.Empty;
            string __tmp5Suffix = string.Empty;
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateAnnotations(enm));
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //45:27
                }
            }
            string __tmp7Prefix = "public enum "; //46:1
            string __tmp8Suffix = " {"; //46:29
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(enm.JavaName());
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                while(__tmp9_first || !__tmp9Reader.EndOfStream)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    if (__tmp9Line == null)
                    {
                        __tmp9Line = "";
                    }
                    __out.Append(__tmp7Prefix);
                    __out.Append(__tmp9Line);
                    __out.Append(__tmp8Suffix);
                    __out.AppendLine(); //46:31
                }
            }
            var __loop5_results = 
                (from __loop5_var1 in __Enumerate((enm).GetEnumerator()) //47:11
                from value in __Enumerate((__loop5_var1.EnumLiterals).GetEnumerator()) //47:16
                select new { __loop5_var1 = __loop5_var1, value = value}
                ).ToList(); //47:6
            int __loop5_iteration = 0;
            string delim = ""; //47:36
            foreach (var __tmp10 in __loop5_results)
            {
                ++__loop5_iteration;
                if (__loop5_iteration >= 2) //47:55
                {
                    delim = ","; //47:55
                }
                var __loop5_var1 = __tmp10.__loop5_var1;
                var value = __tmp10.value;
                string __tmp11Prefix = string.Empty;
                string __tmp12Suffix = string.Empty;
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(delim);
                using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
                {
                    bool __tmp13_first = true;
                    while(__tmp13_first || !__tmp13Reader.EndOfStream)
                    {
                        __tmp13_first = false;
                        string __tmp13Line = __tmp13Reader.ReadLine();
                        if (__tmp13Line == null)
                        {
                            __tmp13Line = "";
                        }
                        __out.Append(__tmp11Prefix);
                        __out.Append(__tmp13Line);
                        __out.Append(__tmp12Suffix);
                        __out.AppendLine(); //48:8
                    }
                }
                string __tmp14Prefix = "    "; //49:1
                string __tmp15Suffix = string.Empty; 
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(value.Name);
                using(StreamReader __tmp16Reader = new StreamReader(this.__ToStream(__tmp16.ToString())))
                {
                    bool __tmp16_first = true;
                    while(__tmp16_first || !__tmp16Reader.EndOfStream)
                    {
                        __tmp16_first = false;
                        string __tmp16Line = __tmp16Reader.ReadLine();
                        if (__tmp16Line == null)
                        {
                            __tmp16Line = "";
                        }
                        __out.Append(__tmp14Prefix);
                        __out.Append(__tmp16Line);
                        __out.Append(__tmp15Suffix);
                    }
                }
            }
            __out.Append(";"); //51:1
            __out.AppendLine(); //51:2
            var __loop6_results = 
                (from __loop6_var1 in __Enumerate((enm).GetEnumerator()) //52:7
                from op in __Enumerate((__loop6_var1.Operations).GetEnumerator()) //52:12
                select new { __loop6_var1 = __loop6_var1, op = op}
                ).ToList(); //52:2
            int __loop6_iteration = 0;
            foreach (var __tmp17 in __loop6_results)
            {
                ++__loop6_iteration;
                var __loop6_var1 = __tmp17.__loop6_var1;
                var op = __tmp17.op;
                __out.AppendLine(); //53:1
                string __tmp18Prefix = "    public "; //54:1
                string __tmp19Suffix = ") {"; //54:105
                StringBuilder __tmp20 = new StringBuilder();
                __tmp20.Append(op.ReturnType.JavaFullPublicName());
                using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
                {
                    bool __tmp20_first = true;
                    while(__tmp20_first || !__tmp20Reader.EndOfStream)
                    {
                        __tmp20_first = false;
                        string __tmp20Line = __tmp20Reader.ReadLine();
                        if (__tmp20Line == null)
                        {
                            __tmp20Line = "";
                        }
                        __out.Append(__tmp18Prefix);
                        __out.Append(__tmp20Line);
                    }
                }
                string __tmp21Line = " "; //54:48
                __out.Append(__tmp21Line);
                StringBuilder __tmp22 = new StringBuilder();
                __tmp22.Append(op.Name.ToCamelCase());
                using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                {
                    bool __tmp22_first = true;
                    while(__tmp22_first || !__tmp22Reader.EndOfStream)
                    {
                        __tmp22_first = false;
                        string __tmp22Line = __tmp22Reader.ReadLine();
                        if (__tmp22Line == null)
                        {
                            __tmp22Line = "";
                        }
                        __out.Append(__tmp22Line);
                    }
                }
                string __tmp23Line = "("; //54:72
                __out.Append(__tmp23Line);
                StringBuilder __tmp24 = new StringBuilder();
                __tmp24.Append(GetEnumImplParameters(enm, op));
                using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                {
                    bool __tmp24_first = true;
                    while(__tmp24_first || !__tmp24Reader.EndOfStream)
                    {
                        __tmp24_first = false;
                        string __tmp24Line = __tmp24Reader.ReadLine();
                        if (__tmp24Line == null)
                        {
                            __tmp24Line = "";
                        }
                        __out.Append(__tmp24Line);
                        __out.Append(__tmp19Suffix);
                        __out.AppendLine(); //54:108
                    }
                }
                string __tmp25Prefix = "        "; //55:1
                string __tmp26Suffix = ");"; //55:162
                StringBuilder __tmp27 = new StringBuilder();
                __tmp27.Append(GetReturn(op));
                using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
                {
                    bool __tmp27_first = true;
                    while(__tmp27_first || !__tmp27Reader.EndOfStream)
                    {
                        __tmp27_first = false;
                        string __tmp27Line = __tmp27Reader.ReadLine();
                        if (__tmp27Line == null)
                        {
                            __tmp27Line = "";
                        }
                        __out.Append(__tmp25Prefix);
                        __out.Append(__tmp27Line);
                    }
                }
                StringBuilder __tmp28 = new StringBuilder();
                __tmp28.Append(enm.Model.Name);
                using(StreamReader __tmp28Reader = new StreamReader(this.__ToStream(__tmp28.ToString())))
                {
                    bool __tmp28_first = true;
                    while(__tmp28_first || !__tmp28Reader.EndOfStream)
                    {
                        __tmp28_first = false;
                        string __tmp28Line = __tmp28Reader.ReadLine();
                        if (__tmp28Line == null)
                        {
                            __tmp28Line = "";
                        }
                        __out.Append(__tmp28Line);
                    }
                }
                string __tmp29Line = "ImplementationProvider.implementation()."; //55:40
                __out.Append(__tmp29Line);
                StringBuilder __tmp30 = new StringBuilder();
                __tmp30.Append(op.Parent.JavaName());
                using(StreamReader __tmp30Reader = new StreamReader(this.__ToStream(__tmp30.ToString())))
                {
                    bool __tmp30_first = true;
                    while(__tmp30_first || !__tmp30Reader.EndOfStream)
                    {
                        __tmp30_first = false;
                        string __tmp30Line = __tmp30Reader.ReadLine();
                        if (__tmp30Line == null)
                        {
                            __tmp30Line = "";
                        }
                        __out.Append(__tmp30Line);
                    }
                }
                string __tmp31Line = "_"; //55:102
                __out.Append(__tmp31Line);
                StringBuilder __tmp32 = new StringBuilder();
                __tmp32.Append(op.Name.ToCamelCase());
                using(StreamReader __tmp32Reader = new StreamReader(this.__ToStream(__tmp32.ToString())))
                {
                    bool __tmp32_first = true;
                    while(__tmp32_first || !__tmp32Reader.EndOfStream)
                    {
                        __tmp32_first = false;
                        string __tmp32Line = __tmp32Reader.ReadLine();
                        if (__tmp32Line == null)
                        {
                            __tmp32Line = "";
                        }
                        __out.Append(__tmp32Line);
                    }
                }
                string __tmp33Line = "("; //55:126
                __out.Append(__tmp33Line);
                StringBuilder __tmp34 = new StringBuilder();
                __tmp34.Append(GetEnumImplCallParameterNames(op));
                using(StreamReader __tmp34Reader = new StreamReader(this.__ToStream(__tmp34.ToString())))
                {
                    bool __tmp34_first = true;
                    while(__tmp34_first || !__tmp34Reader.EndOfStream)
                    {
                        __tmp34_first = false;
                        string __tmp34Line = __tmp34Reader.ReadLine();
                        if (__tmp34Line == null)
                        {
                            __tmp34Line = "";
                        }
                        __out.Append(__tmp34Line);
                        __out.Append(__tmp26Suffix);
                        __out.AppendLine(); //55:164
                    }
                }
                __out.Append("    }"); //56:1
                __out.AppendLine(); //56:6
            }
            __out.Append("}"); //58:1
            __out.AppendLine(); //58:2
            __out.AppendLine(); //59:1
            return __out.ToString();
        }

        public string GetAncestors(MetaClass cls) //62:1
        {
            string result = ""; //63:2
            var __loop7_results = 
                (from __loop7_var1 in __Enumerate((cls).GetEnumerator()) //64:7
                from super in __Enumerate((__loop7_var1.SuperClasses).GetEnumerator()) //64:12
                select new { __loop7_var1 = __loop7_var1, super = super}
                ).ToList(); //64:2
            int __loop7_iteration = 0;
            string delim = " extends "; //64:32
            foreach (var __tmp1 in __loop7_results)
            {
                ++__loop7_iteration;
                if (__loop7_iteration >= 2) //64:60
                {
                    delim = ", "; //64:60
                }
                var __loop7_var1 = __tmp1.__loop7_var1;
                var super = __tmp1.super;
                result += delim + super.JavaFullName(); //65:3
            }
            return result; //67:2
        }

        public string GenerateInterface(MetaClass cls) //70:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //71:1
            string __tmp2Suffix = ";"; //71:35
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(cls.Namespace.JavaName());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //71:36
                }
            }
            __out.AppendLine(); //72:1
            string __tmp4Prefix = string.Empty;
            string __tmp5Suffix = string.Empty;
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(GenerateAnnotations(cls));
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //73:27
                }
            }
            string __tmp7Prefix = "public interface "; //74:1
            string __tmp8Suffix = string.Empty; 
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(cls.JavaName());
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                while(__tmp9_first || !__tmp9Reader.EndOfStream)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    if (__tmp9Line == null)
                    {
                        __tmp9Line = "";
                    }
                    __out.Append(__tmp7Prefix);
                    __out.Append(__tmp9Line);
                }
            }
            StringBuilder __tmp10 = new StringBuilder();
            __tmp10.Append(GetAncestors(cls));
            using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
            {
                bool __tmp10_first = true;
                while(__tmp10_first || !__tmp10Reader.EndOfStream)
                {
                    __tmp10_first = false;
                    string __tmp10Line = __tmp10Reader.ReadLine();
                    if (__tmp10Line == null)
                    {
                        __tmp10Line = "";
                    }
                    __out.Append(__tmp10Line);
                    __out.Append(__tmp8Suffix);
                    __out.AppendLine(); //74:53
                }
            }
            __out.Append("{"); //75:1
            __out.AppendLine(); //75:2
            var __loop8_results = 
                (from __loop8_var1 in __Enumerate((cls).GetEnumerator()) //76:11
                from prop in __Enumerate((__loop8_var1.Properties).GetEnumerator()) //76:16
                select new { __loop8_var1 = __loop8_var1, prop = prop}
                ).ToList(); //76:6
            int __loop8_iteration = 0;
            foreach (var __tmp11 in __loop8_results)
            {
                ++__loop8_iteration;
                var __loop8_var1 = __tmp11.__loop8_var1;
                var prop = __tmp11.prop;
                string __tmp12Prefix = "    "; //77:1
                string __tmp13Suffix = string.Empty; 
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(GenerateProperty(prop));
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_first = true;
                    while(__tmp14_first || !__tmp14Reader.EndOfStream)
                    {
                        __tmp14_first = false;
                        string __tmp14Line = __tmp14Reader.ReadLine();
                        if (__tmp14Line == null)
                        {
                            __tmp14Line = "";
                        }
                        __out.Append(__tmp12Prefix);
                        __out.Append(__tmp14Line);
                        __out.Append(__tmp13Suffix);
                        __out.AppendLine(); //77:29
                    }
                }
            }
            __out.AppendLine(); //79:1
            var __loop9_results = 
                (from __loop9_var1 in __Enumerate((cls).GetEnumerator()) //80:11
                from op in __Enumerate((__loop9_var1.Operations).GetEnumerator()) //80:16
                select new { __loop9_var1 = __loop9_var1, op = op}
                ).ToList(); //80:6
            int __loop9_iteration = 0;
            foreach (var __tmp15 in __loop9_results)
            {
                ++__loop9_iteration;
                var __loop9_var1 = __tmp15.__loop9_var1;
                var op = __tmp15.op;
                string __tmp16Prefix = "    "; //81:1
                string __tmp17Suffix = string.Empty; 
                StringBuilder __tmp18 = new StringBuilder();
                __tmp18.Append(GenerateOperation(op));
                using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
                {
                    bool __tmp18_first = true;
                    while(__tmp18_first || !__tmp18Reader.EndOfStream)
                    {
                        __tmp18_first = false;
                        string __tmp18Line = __tmp18Reader.ReadLine();
                        if (__tmp18Line == null)
                        {
                            __tmp18Line = "";
                        }
                        __out.Append(__tmp16Prefix);
                        __out.Append(__tmp18Line);
                        __out.Append(__tmp17Suffix);
                        __out.AppendLine(); //81:28
                    }
                }
            }
            __out.Append("}"); //83:1
            __out.AppendLine(); //83:2
            __out.AppendLine(); //84:1
            return __out.ToString();
        }

        public string GenerateProperty(MetaProperty prop) //87:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty; 
            string __tmp2Suffix = "();"; //88:68
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(prop.Type.JavaFullPublicName());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                }
            }
            string __tmp4Line = " "; //88:33
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(("get" + prop.Name).SafeJavaName());
            using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
            {
                bool __tmp5_first = true;
                while(__tmp5_first || !__tmp5Reader.EndOfStream)
                {
                    __tmp5_first = false;
                    string __tmp5Line = __tmp5Reader.ReadLine();
                    if (__tmp5Line == null)
                    {
                        __tmp5Line = "";
                    }
                    __out.Append(__tmp5Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //88:71
                }
            }
            if ((prop.Kind == MetaPropertyKind.Normal || prop.Kind == MetaPropertyKind.Containment) && !(prop.Type is MetaCollectionType)) //89:3
            {
                string __tmp6Prefix = "void "; //90:1
                string __tmp7Suffix = " value);"; //90:73
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(("set" + prop.Name).SafeJavaName());
                using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
                {
                    bool __tmp8_first = true;
                    while(__tmp8_first || !__tmp8Reader.EndOfStream)
                    {
                        __tmp8_first = false;
                        string __tmp8Line = __tmp8Reader.ReadLine();
                        if (__tmp8Line == null)
                        {
                            __tmp8Line = "";
                        }
                        __out.Append(__tmp6Prefix);
                        __out.Append(__tmp8Line);
                    }
                }
                string __tmp9Line = "("; //90:40
                __out.Append(__tmp9Line);
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(prop.Type.JavaFullPublicName());
                using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
                {
                    bool __tmp10_first = true;
                    while(__tmp10_first || !__tmp10Reader.EndOfStream)
                    {
                        __tmp10_first = false;
                        string __tmp10Line = __tmp10Reader.ReadLine();
                        if (__tmp10Line == null)
                        {
                            __tmp10Line = "";
                        }
                        __out.Append(__tmp10Line);
                        __out.Append(__tmp7Suffix);
                        __out.AppendLine(); //90:81
                    }
                }
            }
            return __out.ToString();
        }

        public string GetParameters(MetaOperation op, bool defaultValues) //94:1
        {
            string result = ""; //95:2
            var __loop10_results = 
                (from __loop10_var1 in __Enumerate((op).GetEnumerator()) //96:7
                from param in __Enumerate((__loop10_var1.Parameters).GetEnumerator()) //96:11
                select new { __loop10_var1 = __loop10_var1, param = param}
                ).ToList(); //96:2
            int __loop10_iteration = 0;
            string delim = ""; //96:29
            foreach (var __tmp1 in __loop10_results)
            {
                ++__loop10_iteration;
                if (__loop10_iteration >= 2) //96:48
                {
                    delim = ", "; //96:48
                }
                var __loop10_var1 = __tmp1.__loop10_var1;
                var param = __tmp1.param;
                result += delim + param.Type.JavaFullPublicName() + " " + param.Name; //97:3
            }
            return result; //99:2
        }

        public string GetImplParameters(MetaClass cls, MetaOperation op) //102:1
        {
            string result = cls.JavaFullName() + " _this"; //103:2
            string delim = ", "; //104:2
            var __loop11_results = 
                (from __loop11_var1 in __Enumerate((op).GetEnumerator()) //105:7
                from param in __Enumerate((__loop11_var1.Parameters).GetEnumerator()) //105:11
                select new { __loop11_var1 = __loop11_var1, param = param}
                ).ToList(); //105:2
            int __loop11_iteration = 0;
            foreach (var __tmp1 in __loop11_results)
            {
                ++__loop11_iteration;
                var __loop11_var1 = __tmp1.__loop11_var1;
                var param = __tmp1.param;
                result += delim + param.Type.JavaFullPublicName() + " " + param.Name; //106:3
            }
            return result; //108:2
        }

        public string GetImplParameters(MetaEnum enm, MetaOperation op) //111:1
        {
            string result = enm.JavaFullName() + " _this"; //112:2
            string delim = ", "; //113:2
            var __loop12_results = 
                (from __loop12_var1 in __Enumerate((op).GetEnumerator()) //114:7
                from param in __Enumerate((__loop12_var1.Parameters).GetEnumerator()) //114:11
                select new { __loop12_var1 = __loop12_var1, param = param}
                ).ToList(); //114:2
            int __loop12_iteration = 0;
            foreach (var __tmp1 in __loop12_results)
            {
                ++__loop12_iteration;
                var __loop12_var1 = __tmp1.__loop12_var1;
                var param = __tmp1.param;
                result += delim + param.Type.JavaFullPublicName() + " " + param.Name; //115:3
            }
            return result; //117:2
        }

        public string GetEnumImplParameters(MetaEnum enm, MetaOperation op) //120:1
        {
            string result = enm.JavaFullName() + " _this"; //121:2
            string delim = ", "; //122:2
            var __loop13_results = 
                (from __loop13_var1 in __Enumerate((op).GetEnumerator()) //123:7
                from param in __Enumerate((__loop13_var1.Parameters).GetEnumerator()) //123:11
                select new { __loop13_var1 = __loop13_var1, param = param}
                ).ToList(); //123:2
            int __loop13_iteration = 0;
            foreach (var __tmp1 in __loop13_results)
            {
                ++__loop13_iteration;
                var __loop13_var1 = __tmp1.__loop13_var1;
                var param = __tmp1.param;
                result += delim + param.Type.JavaFullPublicName() + " " + param.Name; //124:3
            }
            return result; //126:2
        }

        public string GetEnumImplCallParameterNames(MetaOperation op) //129:1
        {
            string result = "_this"; //130:2
            string delim = ", "; //131:2
            var __loop14_results = 
                (from __loop14_var1 in __Enumerate((op).GetEnumerator()) //132:7
                from param in __Enumerate((__loop14_var1.Parameters).GetEnumerator()) //132:11
                select new { __loop14_var1 = __loop14_var1, param = param}
                ).ToList(); //132:2
            int __loop14_iteration = 0;
            foreach (var __tmp1 in __loop14_results)
            {
                ++__loop14_iteration;
                var __loop14_var1 = __tmp1.__loop14_var1;
                var param = __tmp1.param;
                result += delim + param.Name; //133:3
            }
            return result; //135:2
        }

        public string GetImplCallParameterNames(MetaOperation op) //138:1
        {
            string result = "this"; //139:2
            string delim = ", "; //140:2
            var __loop15_results = 
                (from __loop15_var1 in __Enumerate((op).GetEnumerator()) //141:7
                from param in __Enumerate((__loop15_var1.Parameters).GetEnumerator()) //141:11
                select new { __loop15_var1 = __loop15_var1, param = param}
                ).ToList(); //141:2
            int __loop15_iteration = 0;
            foreach (var __tmp1 in __loop15_results)
            {
                ++__loop15_iteration;
                var __loop15_var1 = __tmp1.__loop15_var1;
                var param = __tmp1.param;
                result += delim + param.Name; //142:3
            }
            return result; //144:2
        }

        public string GenerateOperation(MetaOperation op) //147:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty; 
            string __tmp2Suffix = ");"; //148:87
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(op.ReturnType.JavaFullPublicName());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                }
            }
            string __tmp4Line = " "; //148:37
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(op.Name.ToCamelCase());
            using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
            {
                bool __tmp5_first = true;
                while(__tmp5_first || !__tmp5Reader.EndOfStream)
                {
                    __tmp5_first = false;
                    string __tmp5Line = __tmp5Reader.ReadLine();
                    if (__tmp5Line == null)
                    {
                        __tmp5Line = "";
                    }
                    __out.Append(__tmp5Line);
                }
            }
            string __tmp6Line = "("; //148:61
            __out.Append(__tmp6Line);
            StringBuilder __tmp7 = new StringBuilder();
            __tmp7.Append(GetParameters(op, true));
            using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
            {
                bool __tmp7_first = true;
                while(__tmp7_first || !__tmp7Reader.EndOfStream)
                {
                    __tmp7_first = false;
                    string __tmp7Line = __tmp7Reader.ReadLine();
                    if (__tmp7Line == null)
                    {
                        __tmp7Line = "";
                    }
                    __out.Append(__tmp7Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //148:89
                }
            }
            return __out.ToString();
        }

        public string GenerateInterfaceImpl(MetaModel model, MetaClass cls) //151:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //152:1
            string __tmp2Suffix = ";"; //152:35
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(cls.Namespace.JavaName());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //152:36
                }
            }
            __out.AppendLine(); //153:1
            string __tmp4Prefix = "class "; //154:1
            string __tmp5Suffix = " {"; //154:93
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(cls.JavaImplName());
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                }
            }
            string __tmp7Line = " extends metadslx.core.ModelObject implements "; //154:27
            __out.Append(__tmp7Line);
            StringBuilder __tmp8 = new StringBuilder();
            __tmp8.Append(cls.JavaFullName());
            using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
            {
                bool __tmp8_first = true;
                while(__tmp8_first || !__tmp8Reader.EndOfStream)
                {
                    __tmp8_first = false;
                    string __tmp8Line = __tmp8Reader.ReadLine();
                    if (__tmp8Line == null)
                    {
                        __tmp8Line = "";
                    }
                    __out.Append(__tmp8Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //154:95
                }
            }
            __out.Append("    static {"); //155:1
            __out.AppendLine(); //155:13
            string __tmp9Prefix = "        "; //156:1
            string __tmp10Suffix = ".staticInit();"; //156:45
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(cls.Model.JavaFullDescriptorName());
            using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
            {
                bool __tmp11_first = true;
                while(__tmp11_first || !__tmp11Reader.EndOfStream)
                {
                    __tmp11_first = false;
                    string __tmp11Line = __tmp11Reader.ReadLine();
                    if (__tmp11Line == null)
                    {
                        __tmp11Line = "";
                    }
                    __out.Append(__tmp9Prefix);
                    __out.Append(__tmp11Line);
                    __out.Append(__tmp10Suffix);
                    __out.AppendLine(); //156:59
                }
            }
            __out.Append("    }"); //157:1
            __out.AppendLine(); //157:6
            __out.AppendLine(); //158:1
            __out.Append("	@Override"); //159:1
            __out.AppendLine(); //159:11
            __out.Append("    public metadslx.core.MetaModel mMetaModel() {"); //160:1
            __out.AppendLine(); //160:50
            string __tmp12Prefix = "        return "; //161:1
            string __tmp13Suffix = "; "; //161:50
            StringBuilder __tmp14 = new StringBuilder();
            __tmp14.Append(cls.Model.JavaFullInstanceName());
            using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
            {
                bool __tmp14_first = true;
                while(__tmp14_first || !__tmp14Reader.EndOfStream)
                {
                    __tmp14_first = false;
                    string __tmp14Line = __tmp14Reader.ReadLine();
                    if (__tmp14Line == null)
                    {
                        __tmp14Line = "";
                    }
                    __out.Append(__tmp12Prefix);
                    __out.Append(__tmp14Line);
                    __out.Append(__tmp13Suffix);
                    __out.AppendLine(); //161:52
                }
            }
            __out.Append("    }"); //162:1
            __out.AppendLine(); //162:6
            __out.AppendLine(); //163:1
            __out.Append("	@Override"); //164:1
            __out.AppendLine(); //164:11
            __out.Append("    public metadslx.core.MetaClass mMetaClass() {"); //165:1
            __out.AppendLine(); //165:50
            string __tmp15Prefix = "        return "; //166:1
            string __tmp16Suffix = "; "; //166:44
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(cls.JavaFullInstanceName());
            using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
            {
                bool __tmp17_first = true;
                while(__tmp17_first || !__tmp17Reader.EndOfStream)
                {
                    __tmp17_first = false;
                    string __tmp17Line = __tmp17Reader.ReadLine();
                    if (__tmp17Line == null)
                    {
                        __tmp17Line = "";
                    }
                    __out.Append(__tmp15Prefix);
                    __out.Append(__tmp17Line);
                    __out.Append(__tmp16Suffix);
                    __out.AppendLine(); //166:46
                }
            }
            __out.Append("    }"); //167:1
            __out.AppendLine(); //167:6
            __out.AppendLine(); //168:1
            string __tmp18Prefix = "    "; //169:1
            string __tmp19Suffix = string.Empty; 
            StringBuilder __tmp20 = new StringBuilder();
            __tmp20.Append(GenerateConstructorImpl(model, cls));
            using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
            {
                bool __tmp20_first = true;
                while(__tmp20_first || !__tmp20Reader.EndOfStream)
                {
                    __tmp20_first = false;
                    string __tmp20Line = __tmp20Reader.ReadLine();
                    if (__tmp20Line == null)
                    {
                        __tmp20Line = "";
                    }
                    __out.Append(__tmp18Prefix);
                    __out.Append(__tmp20Line);
                    __out.Append(__tmp19Suffix);
                    __out.AppendLine(); //169:42
                }
            }
            HashSet<string> propMethodNames = new HashSet<string>(); //170:3
            var __loop16_results = 
                (from __loop16_var1 in __Enumerate((cls).GetEnumerator()) //171:11
                from prop in __Enumerate((__loop16_var1.GetAllProperties()).GetEnumerator()) //171:16
                select new { __loop16_var1 = __loop16_var1, prop = prop}
                ).ToList(); //171:6
            int __loop16_iteration = 0;
            foreach (var __tmp21 in __loop16_results)
            {
                ++__loop16_iteration;
                var __loop16_var1 = __tmp21.__loop16_var1;
                var prop = __tmp21.prop;
                string __tmp22Prefix = "    "; //172:1
                string __tmp23Suffix = string.Empty; 
                StringBuilder __tmp24 = new StringBuilder();
                __tmp24.Append(GeneratePropertyImpl(model, cls, prop, propMethodNames));
                using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                {
                    bool __tmp24_first = true;
                    while(__tmp24_first || !__tmp24Reader.EndOfStream)
                    {
                        __tmp24_first = false;
                        string __tmp24Line = __tmp24Reader.ReadLine();
                        if (__tmp24Line == null)
                        {
                            __tmp24Line = "";
                        }
                        __out.Append(__tmp22Prefix);
                        __out.Append(__tmp24Line);
                        __out.Append(__tmp23Suffix);
                        __out.AppendLine(); //172:62
                    }
                }
            }
            HashSet<string> methodNames = new HashSet<string>(); //174:3
            var __loop17_results = 
                (from __loop17_var1 in __Enumerate((cls).GetEnumerator()) //175:11
                from op in __Enumerate((__loop17_var1.GetAllOperations()).GetEnumerator()) //175:16
                select new { __loop17_var1 = __loop17_var1, op = op}
                ).ToList(); //175:6
            int __loop17_iteration = 0;
            foreach (var __tmp25 in __loop17_results)
            {
                ++__loop17_iteration;
                var __loop17_var1 = __tmp25.__loop17_var1;
                var op = __tmp25.op;
                string __tmp26Prefix = "    "; //176:1
                string __tmp27Suffix = string.Empty; 
                StringBuilder __tmp28 = new StringBuilder();
                __tmp28.Append(GenerateOperationImpl(model, op, methodNames));
                using(StreamReader __tmp28Reader = new StreamReader(this.__ToStream(__tmp28.ToString())))
                {
                    bool __tmp28_first = true;
                    while(__tmp28_first || !__tmp28Reader.EndOfStream)
                    {
                        __tmp28_first = false;
                        string __tmp28Line = __tmp28Reader.ReadLine();
                        if (__tmp28Line == null)
                        {
                            __tmp28Line = "";
                        }
                        __out.Append(__tmp26Prefix);
                        __out.Append(__tmp28Line);
                        __out.Append(__tmp27Suffix);
                        __out.AppendLine(); //176:52
                    }
                }
            }
            __out.Append("}"); //178:1
            __out.AppendLine(); //178:2
            __out.AppendLine(); //179:1
            return __out.ToString();
        }

        public string GeneratePropertyDeclaration(MetaModel model, MetaClass cls, MetaProperty prop) //182:1
        {
            StringBuilder __out = new StringBuilder();
            if (prop.Class == cls) //183:2
            {
                string __tmp1Prefix = string.Empty;
                string __tmp2Suffix = string.Empty;
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(GenerateAnnotations(prop));
                using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                {
                    bool __tmp3_first = true;
                    while(__tmp3_first || !__tmp3Reader.EndOfStream)
                    {
                        __tmp3_first = false;
                        string __tmp3Line = __tmp3Reader.ReadLine();
                        if (__tmp3Line == null)
                        {
                            __tmp3Line = "";
                        }
                        __out.Append(__tmp1Prefix);
                        __out.Append(__tmp3Line);
                        __out.Append(__tmp2Suffix);
                        __out.AppendLine(); //184:28
                    }
                }
                if (prop.Kind == MetaPropertyKind.Containment) //185:2
                {
                    __out.Append("@metadslx.core.Containment"); //186:1
                    __out.AppendLine(); //186:27
                }
                if (prop.Kind != MetaPropertyKind.Normal && prop.Kind != MetaPropertyKind.Containment) //188:2
                {
                    __out.Append("@metadslx.core.Readonly"); //189:1
                    __out.AppendLine(); //189:24
                }
                var __loop18_results = 
                    (from p in __Enumerate((prop.OppositeProperties).GetEnumerator()) //191:7
                    select new { p = p}
                    ).ToList(); //191:2
                int __loop18_iteration = 0;
                foreach (var __tmp4 in __loop18_results)
                {
                    ++__loop18_iteration;
                    var p = __tmp4.p;
                    string __tmp5Prefix = "@metadslx.core.Opposite(declaringType="; //192:1
                    string __tmp6Suffix = "\")"; //192:103
                    StringBuilder __tmp7 = new StringBuilder();
                    __tmp7.Append(p.Class.JavaFullDescriptorName());
                    using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
                    {
                        bool __tmp7_first = true;
                        while(__tmp7_first || !__tmp7Reader.EndOfStream)
                        {
                            __tmp7_first = false;
                            string __tmp7Line = __tmp7Reader.ReadLine();
                            if (__tmp7Line == null)
                            {
                                __tmp7Line = "";
                            }
                            __out.Append(__tmp5Prefix);
                            __out.Append(__tmp7Line);
                        }
                    }
                    string __tmp8Line = ".class, propertyName=\""; //192:73
                    __out.Append(__tmp8Line);
                    StringBuilder __tmp9 = new StringBuilder();
                    __tmp9.Append(p.Name);
                    using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
                    {
                        bool __tmp9_first = true;
                        while(__tmp9_first || !__tmp9Reader.EndOfStream)
                        {
                            __tmp9_first = false;
                            string __tmp9Line = __tmp9Reader.ReadLine();
                            if (__tmp9Line == null)
                            {
                                __tmp9Line = "";
                            }
                            __out.Append(__tmp9Line);
                            __out.Append(__tmp6Suffix);
                            __out.AppendLine(); //192:105
                        }
                    }
                }
                var __loop19_results = 
                    (from p in __Enumerate((prop.SubsettedProperties).GetEnumerator()) //194:7
                    select new { p = p}
                    ).ToList(); //194:2
                int __loop19_iteration = 0;
                foreach (var __tmp10 in __loop19_results)
                {
                    ++__loop19_iteration;
                    var p = __tmp10.p;
                    if (cls.GetAllSuperClasses(false).Contains(p.Class)) //195:3
                    {
                        string __tmp11Prefix = "@metadslx.core.Subsets(declaringType="; //196:1
                        string __tmp12Suffix = "\")"; //196:102
                        StringBuilder __tmp13 = new StringBuilder();
                        __tmp13.Append(p.Class.JavaFullDescriptorName());
                        using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
                        {
                            bool __tmp13_first = true;
                            while(__tmp13_first || !__tmp13Reader.EndOfStream)
                            {
                                __tmp13_first = false;
                                string __tmp13Line = __tmp13Reader.ReadLine();
                                if (__tmp13Line == null)
                                {
                                    __tmp13Line = "";
                                }
                                __out.Append(__tmp11Prefix);
                                __out.Append(__tmp13Line);
                            }
                        }
                        string __tmp14Line = ".class, propertyName=\""; //196:72
                        __out.Append(__tmp14Line);
                        StringBuilder __tmp15 = new StringBuilder();
                        __tmp15.Append(p.Name);
                        using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                        {
                            bool __tmp15_first = true;
                            while(__tmp15_first || !__tmp15Reader.EndOfStream)
                            {
                                __tmp15_first = false;
                                string __tmp15Line = __tmp15Reader.ReadLine();
                                if (__tmp15Line == null)
                                {
                                    __tmp15Line = "";
                                }
                                __out.Append(__tmp15Line);
                                __out.Append(__tmp12Suffix);
                                __out.AppendLine(); //196:104
                            }
                        }
                    }
                    else //197:3
                    {
                        string __tmp16Prefix = "// ERROR: subsetted property '"; //198:1
                        string __tmp17Suffix = "' must be a property of an ancestor class"; //198:59
                        StringBuilder __tmp18 = new StringBuilder();
                        __tmp18.Append(p.JavaFullDescriptorName());
                        using(StreamReader __tmp18Reader = new StreamReader(this.__ToStream(__tmp18.ToString())))
                        {
                            bool __tmp18_first = true;
                            while(__tmp18_first || !__tmp18Reader.EndOfStream)
                            {
                                __tmp18_first = false;
                                string __tmp18Line = __tmp18Reader.ReadLine();
                                if (__tmp18Line == null)
                                {
                                    __tmp18Line = "";
                                }
                                __out.Append(__tmp16Prefix);
                                __out.Append(__tmp18Line);
                                __out.Append(__tmp17Suffix);
                                __out.AppendLine(); //198:100
                            }
                        }
                    }
                }
                var __loop20_results = 
                    (from p in __Enumerate((prop.RedefinedProperties).GetEnumerator()) //201:7
                    select new { p = p}
                    ).ToList(); //201:2
                int __loop20_iteration = 0;
                foreach (var __tmp19 in __loop20_results)
                {
                    ++__loop20_iteration;
                    var p = __tmp19.p;
                    if (cls.GetAllSuperClasses(false).Contains(p.Class)) //202:3
                    {
                        string __tmp20Prefix = "@metadslx.core.Redefines(declaringType="; //203:1
                        string __tmp21Suffix = "\")"; //203:104
                        StringBuilder __tmp22 = new StringBuilder();
                        __tmp22.Append(p.Class.JavaFullDescriptorName());
                        using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                        {
                            bool __tmp22_first = true;
                            while(__tmp22_first || !__tmp22Reader.EndOfStream)
                            {
                                __tmp22_first = false;
                                string __tmp22Line = __tmp22Reader.ReadLine();
                                if (__tmp22Line == null)
                                {
                                    __tmp22Line = "";
                                }
                                __out.Append(__tmp20Prefix);
                                __out.Append(__tmp22Line);
                            }
                        }
                        string __tmp23Line = ".class, propertyName=\""; //203:74
                        __out.Append(__tmp23Line);
                        StringBuilder __tmp24 = new StringBuilder();
                        __tmp24.Append(p.Name);
                        using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                        {
                            bool __tmp24_first = true;
                            while(__tmp24_first || !__tmp24Reader.EndOfStream)
                            {
                                __tmp24_first = false;
                                string __tmp24Line = __tmp24Reader.ReadLine();
                                if (__tmp24Line == null)
                                {
                                    __tmp24Line = "";
                                }
                                __out.Append(__tmp24Line);
                                __out.Append(__tmp21Suffix);
                                __out.AppendLine(); //203:106
                            }
                        }
                    }
                    else //204:3
                    {
                        string __tmp25Prefix = "// ERROR: redefined property '"; //205:1
                        string __tmp26Suffix = "' must be a property of an ancestor class"; //205:59
                        StringBuilder __tmp27 = new StringBuilder();
                        __tmp27.Append(p.JavaFullDescriptorName());
                        using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
                        {
                            bool __tmp27_first = true;
                            while(__tmp27_first || !__tmp27Reader.EndOfStream)
                            {
                                __tmp27_first = false;
                                string __tmp27Line = __tmp27Reader.ReadLine();
                                if (__tmp27Line == null)
                                {
                                    __tmp27Line = "";
                                }
                                __out.Append(__tmp25Prefix);
                                __out.Append(__tmp27Line);
                                __out.Append(__tmp26Suffix);
                                __out.AppendLine(); //205:100
                            }
                        }
                    }
                }
                if (prop.Type is MetaCollectionType) //208:2
                {
                    string __tmp28Prefix = "public static final ModelProperty "; //209:1
                    string __tmp29Suffix = "Property ="; //209:46
                    StringBuilder __tmp30 = new StringBuilder();
                    __tmp30.Append(prop.Name);
                    using(StreamReader __tmp30Reader = new StreamReader(this.__ToStream(__tmp30.ToString())))
                    {
                        bool __tmp30_first = true;
                        while(__tmp30_first || !__tmp30Reader.EndOfStream)
                        {
                            __tmp30_first = false;
                            string __tmp30Line = __tmp30Reader.ReadLine();
                            if (__tmp30Line == null)
                            {
                                __tmp30Line = "";
                            }
                            __out.Append(__tmp28Prefix);
                            __out.Append(__tmp30Line);
                            __out.Append(__tmp29Suffix);
                            __out.AppendLine(); //209:56
                        }
                    }
                    string __tmp31Prefix = "    metadslx.core.ModelProperty.register(\""; //210:1
                    string __tmp32Suffix = "Property, true));"; //210:396
                    StringBuilder __tmp33 = new StringBuilder();
                    __tmp33.Append(prop.Name);
                    using(StreamReader __tmp33Reader = new StreamReader(this.__ToStream(__tmp33.ToString())))
                    {
                        bool __tmp33_first = true;
                        while(__tmp33_first || !__tmp33Reader.EndOfStream)
                        {
                            __tmp33_first = false;
                            string __tmp33Line = __tmp33Reader.ReadLine();
                            if (__tmp33Line == null)
                            {
                                __tmp33Line = "";
                            }
                            __out.Append(__tmp31Prefix);
                            __out.Append(__tmp33Line);
                        }
                    }
                    string __tmp34Line = "\", "; //210:54
                    __out.Append(__tmp34Line);
                    StringBuilder __tmp35 = new StringBuilder();
                    __tmp35.Append(prop.Type.JavaNonGenericFullName());
                    using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
                    {
                        bool __tmp35_first = true;
                        while(__tmp35_first || !__tmp35Reader.EndOfStream)
                        {
                            __tmp35_first = false;
                            string __tmp35Line = __tmp35Reader.ReadLine();
                            if (__tmp35Line == null)
                            {
                                __tmp35Line = "";
                            }
                            __out.Append(__tmp35Line);
                        }
                    }
                    string __tmp36Line = ".class, "; //210:93
                    __out.Append(__tmp36Line);
                    StringBuilder __tmp37 = new StringBuilder();
                    __tmp37.Append(((MetaCollectionType)prop.Type).InnerType.JavaNonGenericFullName());
                    using(StreamReader __tmp37Reader = new StreamReader(this.__ToStream(__tmp37.ToString())))
                    {
                        bool __tmp37_first = true;
                        while(__tmp37_first || !__tmp37Reader.EndOfStream)
                        {
                            __tmp37_first = false;
                            string __tmp37Line = __tmp37Reader.ReadLine();
                            if (__tmp37Line == null)
                            {
                                __tmp37Line = "";
                            }
                            __out.Append(__tmp37Line);
                        }
                    }
                    string __tmp38Line = ".class, "; //210:169
                    __out.Append(__tmp38Line);
                    StringBuilder __tmp39 = new StringBuilder();
                    __tmp39.Append(prop.Class.JavaFullName());
                    using(StreamReader __tmp39Reader = new StreamReader(this.__ToStream(__tmp39.ToString())))
                    {
                        bool __tmp39_first = true;
                        while(__tmp39_first || !__tmp39Reader.EndOfStream)
                        {
                            __tmp39_first = false;
                            string __tmp39Line = __tmp39Reader.ReadLine();
                            if (__tmp39Line == null)
                            {
                                __tmp39Line = "";
                            }
                            __out.Append(__tmp39Line);
                        }
                    }
                    string __tmp40Line = ".class, "; //210:204
                    __out.Append(__tmp40Line);
                    StringBuilder __tmp41 = new StringBuilder();
                    __tmp41.Append(prop.Class.Model.JavaFullName());
                    using(StreamReader __tmp41Reader = new StreamReader(this.__ToStream(__tmp41.ToString())))
                    {
                        bool __tmp41_first = true;
                        while(__tmp41_first || !__tmp41Reader.EndOfStream)
                        {
                            __tmp41_first = false;
                            string __tmp41Line = __tmp41Reader.ReadLine();
                            if (__tmp41Line == null)
                            {
                                __tmp41Line = "";
                            }
                            __out.Append(__tmp41Line);
                        }
                    }
                    string __tmp42Line = "Descriptor."; //210:245
                    __out.Append(__tmp42Line);
                    StringBuilder __tmp43 = new StringBuilder();
                    __tmp43.Append(prop.Class.JavaName());
                    using(StreamReader __tmp43Reader = new StreamReader(this.__ToStream(__tmp43.ToString())))
                    {
                        bool __tmp43_first = true;
                        while(__tmp43_first || !__tmp43Reader.EndOfStream)
                        {
                            __tmp43_first = false;
                            string __tmp43Line = __tmp43Reader.ReadLine();
                            if (__tmp43Line == null)
                            {
                                __tmp43Line = "";
                            }
                            __out.Append(__tmp43Line);
                        }
                    }
                    string __tmp44Line = ".class, metadslx.core.Lazy.create(() -> "; //210:279
                    __out.Append(__tmp44Line);
                    StringBuilder __tmp45 = new StringBuilder();
                    __tmp45.Append(prop.Class.Model.JavaFullName());
                    using(StreamReader __tmp45Reader = new StreamReader(this.__ToStream(__tmp45.ToString())))
                    {
                        bool __tmp45_first = true;
                        while(__tmp45_first || !__tmp45Reader.EndOfStream)
                        {
                            __tmp45_first = false;
                            string __tmp45Line = __tmp45Reader.ReadLine();
                            if (__tmp45Line == null)
                            {
                                __tmp45Line = "";
                            }
                            __out.Append(__tmp45Line);
                        }
                    }
                    string __tmp46Line = "Instance."; //210:352
                    __out.Append(__tmp46Line);
                    StringBuilder __tmp47 = new StringBuilder();
                    __tmp47.Append(prop.Class.JavaName());
                    using(StreamReader __tmp47Reader = new StreamReader(this.__ToStream(__tmp47.ToString())))
                    {
                        bool __tmp47_first = true;
                        while(__tmp47_first || !__tmp47Reader.EndOfStream)
                        {
                            __tmp47_first = false;
                            string __tmp47Line = __tmp47Reader.ReadLine();
                            if (__tmp47Line == null)
                            {
                                __tmp47Line = "";
                            }
                            __out.Append(__tmp47Line);
                        }
                    }
                    string __tmp48Line = "_"; //210:384
                    __out.Append(__tmp48Line);
                    StringBuilder __tmp49 = new StringBuilder();
                    __tmp49.Append(prop.Name);
                    using(StreamReader __tmp49Reader = new StreamReader(this.__ToStream(__tmp49.ToString())))
                    {
                        bool __tmp49_first = true;
                        while(__tmp49_first || !__tmp49Reader.EndOfStream)
                        {
                            __tmp49_first = false;
                            string __tmp49Line = __tmp49Reader.ReadLine();
                            if (__tmp49Line == null)
                            {
                                __tmp49Line = "";
                            }
                            __out.Append(__tmp49Line);
                            __out.Append(__tmp32Suffix);
                            __out.AppendLine(); //210:413
                        }
                    }
                }
                else //211:2
                {
                    string __tmp50Prefix = "public static final ModelProperty "; //212:1
                    string __tmp51Suffix = "Property ="; //212:46
                    StringBuilder __tmp52 = new StringBuilder();
                    __tmp52.Append(prop.Name);
                    using(StreamReader __tmp52Reader = new StreamReader(this.__ToStream(__tmp52.ToString())))
                    {
                        bool __tmp52_first = true;
                        while(__tmp52_first || !__tmp52Reader.EndOfStream)
                        {
                            __tmp52_first = false;
                            string __tmp52Line = __tmp52Reader.ReadLine();
                            if (__tmp52Line == null)
                            {
                                __tmp52Line = "";
                            }
                            __out.Append(__tmp50Prefix);
                            __out.Append(__tmp52Line);
                            __out.Append(__tmp51Suffix);
                            __out.AppendLine(); //212:56
                        }
                    }
                    string __tmp53Prefix = "    metadslx.core.ModelProperty.register(\""; //213:1
                    string __tmp54Suffix = "Property, true));"; //213:322
                    StringBuilder __tmp55 = new StringBuilder();
                    __tmp55.Append(prop.Name);
                    using(StreamReader __tmp55Reader = new StreamReader(this.__ToStream(__tmp55.ToString())))
                    {
                        bool __tmp55_first = true;
                        while(__tmp55_first || !__tmp55Reader.EndOfStream)
                        {
                            __tmp55_first = false;
                            string __tmp55Line = __tmp55Reader.ReadLine();
                            if (__tmp55Line == null)
                            {
                                __tmp55Line = "";
                            }
                            __out.Append(__tmp53Prefix);
                            __out.Append(__tmp55Line);
                        }
                    }
                    string __tmp56Line = "\", "; //213:54
                    __out.Append(__tmp56Line);
                    StringBuilder __tmp57 = new StringBuilder();
                    __tmp57.Append(prop.Type.JavaFullPublicName());
                    using(StreamReader __tmp57Reader = new StreamReader(this.__ToStream(__tmp57.ToString())))
                    {
                        bool __tmp57_first = true;
                        while(__tmp57_first || !__tmp57Reader.EndOfStream)
                        {
                            __tmp57_first = false;
                            string __tmp57Line = __tmp57Reader.ReadLine();
                            if (__tmp57Line == null)
                            {
                                __tmp57Line = "";
                            }
                            __out.Append(__tmp57Line);
                        }
                    }
                    string __tmp58Line = ".class, null, "; //213:89
                    __out.Append(__tmp58Line);
                    StringBuilder __tmp59 = new StringBuilder();
                    __tmp59.Append(prop.Class.JavaFullName());
                    using(StreamReader __tmp59Reader = new StreamReader(this.__ToStream(__tmp59.ToString())))
                    {
                        bool __tmp59_first = true;
                        while(__tmp59_first || !__tmp59Reader.EndOfStream)
                        {
                            __tmp59_first = false;
                            string __tmp59Line = __tmp59Reader.ReadLine();
                            if (__tmp59Line == null)
                            {
                                __tmp59Line = "";
                            }
                            __out.Append(__tmp59Line);
                        }
                    }
                    string __tmp60Line = ".class, "; //213:130
                    __out.Append(__tmp60Line);
                    StringBuilder __tmp61 = new StringBuilder();
                    __tmp61.Append(prop.Class.Model.JavaFullName());
                    using(StreamReader __tmp61Reader = new StreamReader(this.__ToStream(__tmp61.ToString())))
                    {
                        bool __tmp61_first = true;
                        while(__tmp61_first || !__tmp61Reader.EndOfStream)
                        {
                            __tmp61_first = false;
                            string __tmp61Line = __tmp61Reader.ReadLine();
                            if (__tmp61Line == null)
                            {
                                __tmp61Line = "";
                            }
                            __out.Append(__tmp61Line);
                        }
                    }
                    string __tmp62Line = "Descriptor."; //213:171
                    __out.Append(__tmp62Line);
                    StringBuilder __tmp63 = new StringBuilder();
                    __tmp63.Append(prop.Class.JavaName());
                    using(StreamReader __tmp63Reader = new StreamReader(this.__ToStream(__tmp63.ToString())))
                    {
                        bool __tmp63_first = true;
                        while(__tmp63_first || !__tmp63Reader.EndOfStream)
                        {
                            __tmp63_first = false;
                            string __tmp63Line = __tmp63Reader.ReadLine();
                            if (__tmp63Line == null)
                            {
                                __tmp63Line = "";
                            }
                            __out.Append(__tmp63Line);
                        }
                    }
                    string __tmp64Line = ".class, metadslx.core.Lazy.create(() -> "; //213:205
                    __out.Append(__tmp64Line);
                    StringBuilder __tmp65 = new StringBuilder();
                    __tmp65.Append(prop.Class.Model.JavaFullName());
                    using(StreamReader __tmp65Reader = new StreamReader(this.__ToStream(__tmp65.ToString())))
                    {
                        bool __tmp65_first = true;
                        while(__tmp65_first || !__tmp65Reader.EndOfStream)
                        {
                            __tmp65_first = false;
                            string __tmp65Line = __tmp65Reader.ReadLine();
                            if (__tmp65Line == null)
                            {
                                __tmp65Line = "";
                            }
                            __out.Append(__tmp65Line);
                        }
                    }
                    string __tmp66Line = "Instance."; //213:278
                    __out.Append(__tmp66Line);
                    StringBuilder __tmp67 = new StringBuilder();
                    __tmp67.Append(prop.Class.JavaName());
                    using(StreamReader __tmp67Reader = new StreamReader(this.__ToStream(__tmp67.ToString())))
                    {
                        bool __tmp67_first = true;
                        while(__tmp67_first || !__tmp67Reader.EndOfStream)
                        {
                            __tmp67_first = false;
                            string __tmp67Line = __tmp67Reader.ReadLine();
                            if (__tmp67Line == null)
                            {
                                __tmp67Line = "";
                            }
                            __out.Append(__tmp67Line);
                        }
                    }
                    string __tmp68Line = "_"; //213:310
                    __out.Append(__tmp68Line);
                    StringBuilder __tmp69 = new StringBuilder();
                    __tmp69.Append(prop.Name);
                    using(StreamReader __tmp69Reader = new StreamReader(this.__ToStream(__tmp69.ToString())))
                    {
                        bool __tmp69_first = true;
                        while(__tmp69_first || !__tmp69Reader.EndOfStream)
                        {
                            __tmp69_first = false;
                            string __tmp69Line = __tmp69Reader.ReadLine();
                            if (__tmp69Line == null)
                            {
                                __tmp69Line = "";
                            }
                            __out.Append(__tmp69Line);
                            __out.Append(__tmp54Suffix);
                            __out.AppendLine(); //213:339
                        }
                    }
                }
            }
            __out.AppendLine(); //216:1
            return __out.ToString();
        }

        public string GeneratePropertyImpl(MetaModel model, MetaClass cls, MetaProperty prop, HashSet<string> generated) //219:1
        {
            StringBuilder __out = new StringBuilder();
            if (generated.Add("get" + prop.Name)) //220:2
            {
                __out.AppendLine(); //221:1
                string __tmp1Prefix = "public "; //222:1
                string __tmp2Suffix = "() {"; //222:75
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(prop.Type.JavaFullPublicName());
                using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                {
                    bool __tmp3_first = true;
                    while(__tmp3_first || !__tmp3Reader.EndOfStream)
                    {
                        __tmp3_first = false;
                        string __tmp3Line = __tmp3Reader.ReadLine();
                        if (__tmp3Line == null)
                        {
                            __tmp3Line = "";
                        }
                        __out.Append(__tmp1Prefix);
                        __out.Append(__tmp3Line);
                    }
                }
                string __tmp4Line = " "; //222:40
                __out.Append(__tmp4Line);
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(("get" + prop.Name).SafeJavaName());
                using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                {
                    bool __tmp5_first = true;
                    while(__tmp5_first || !__tmp5Reader.EndOfStream)
                    {
                        __tmp5_first = false;
                        string __tmp5Line = __tmp5Reader.ReadLine();
                        if (__tmp5Line == null)
                        {
                            __tmp5Line = "";
                        }
                        __out.Append(__tmp5Line);
                        __out.Append(__tmp2Suffix);
                        __out.AppendLine(); //222:79
                    }
                }
                string __tmp6Prefix = "    Object result = this.mGet("; //223:1
                string __tmp7Suffix = "); "; //223:62
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(prop.JavaFullDescriptorName());
                using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
                {
                    bool __tmp8_first = true;
                    while(__tmp8_first || !__tmp8Reader.EndOfStream)
                    {
                        __tmp8_first = false;
                        string __tmp8Line = __tmp8Reader.ReadLine();
                        if (__tmp8Line == null)
                        {
                            __tmp8Line = "";
                        }
                        __out.Append(__tmp6Prefix);
                        __out.Append(__tmp8Line);
                        __out.Append(__tmp7Suffix);
                        __out.AppendLine(); //223:65
                    }
                }
                string __tmp9Prefix = "    if (result != null) return ("; //224:1
                string __tmp10Suffix = ")result;"; //224:65
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(prop.Type.JavaFullPublicName());
                using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                {
                    bool __tmp11_first = true;
                    while(__tmp11_first || !__tmp11Reader.EndOfStream)
                    {
                        __tmp11_first = false;
                        string __tmp11Line = __tmp11Reader.ReadLine();
                        if (__tmp11Line == null)
                        {
                            __tmp11Line = "";
                        }
                        __out.Append(__tmp9Prefix);
                        __out.Append(__tmp11Line);
                        __out.Append(__tmp10Suffix);
                        __out.AppendLine(); //224:73
                    }
                }
                string __tmp12Prefix = "    else return ("; //225:1
                string __tmp13Suffix = ";"; //225:81
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(prop.Type.JavaFullPublicName());
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_first = true;
                    while(__tmp14_first || !__tmp14Reader.EndOfStream)
                    {
                        __tmp14_first = false;
                        string __tmp14Line = __tmp14Reader.ReadLine();
                        if (__tmp14Line == null)
                        {
                            __tmp14Line = "";
                        }
                        __out.Append(__tmp12Prefix);
                        __out.Append(__tmp14Line);
                    }
                }
                string __tmp15Line = ")"; //225:50
                __out.Append(__tmp15Line);
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(prop.Type.JavaDefaultValue());
                using(StreamReader __tmp16Reader = new StreamReader(this.__ToStream(__tmp16.ToString())))
                {
                    bool __tmp16_first = true;
                    while(__tmp16_first || !__tmp16Reader.EndOfStream)
                    {
                        __tmp16_first = false;
                        string __tmp16Line = __tmp16Reader.ReadLine();
                        if (__tmp16Line == null)
                        {
                            __tmp16Line = "";
                        }
                        __out.Append(__tmp16Line);
                        __out.Append(__tmp13Suffix);
                        __out.AppendLine(); //225:82
                    }
                }
                __out.Append("}"); //226:1
                __out.AppendLine(); //226:2
            }
            if ((prop.Kind == MetaPropertyKind.Normal || prop.Kind == MetaPropertyKind.Containment) && !(prop.Type is MetaCollectionType)) //228:2
            {
                if (generated.Add("set" + prop.Name)) //229:2
                {
                    __out.AppendLine(); //230:1
                    string __tmp17Prefix = "public void "; //231:1
                    string __tmp18Suffix = " value) {"; //231:80
                    StringBuilder __tmp19 = new StringBuilder();
                    __tmp19.Append(("set" + prop.Name).SafeJavaName());
                    using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
                    {
                        bool __tmp19_first = true;
                        while(__tmp19_first || !__tmp19Reader.EndOfStream)
                        {
                            __tmp19_first = false;
                            string __tmp19Line = __tmp19Reader.ReadLine();
                            if (__tmp19Line == null)
                            {
                                __tmp19Line = "";
                            }
                            __out.Append(__tmp17Prefix);
                            __out.Append(__tmp19Line);
                        }
                    }
                    string __tmp20Line = "("; //231:47
                    __out.Append(__tmp20Line);
                    StringBuilder __tmp21 = new StringBuilder();
                    __tmp21.Append(prop.Type.JavaFullPublicName());
                    using(StreamReader __tmp21Reader = new StreamReader(this.__ToStream(__tmp21.ToString())))
                    {
                        bool __tmp21_first = true;
                        while(__tmp21_first || !__tmp21Reader.EndOfStream)
                        {
                            __tmp21_first = false;
                            string __tmp21Line = __tmp21Reader.ReadLine();
                            if (__tmp21Line == null)
                            {
                                __tmp21Line = "";
                            }
                            __out.Append(__tmp21Line);
                            __out.Append(__tmp18Suffix);
                            __out.AppendLine(); //231:89
                        }
                    }
                    string __tmp22Prefix = "    this.mSet("; //232:1
                    string __tmp23Suffix = ", value);"; //232:46
                    StringBuilder __tmp24 = new StringBuilder();
                    __tmp24.Append(prop.JavaFullDescriptorName());
                    using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                    {
                        bool __tmp24_first = true;
                        while(__tmp24_first || !__tmp24Reader.EndOfStream)
                        {
                            __tmp24_first = false;
                            string __tmp24Line = __tmp24Reader.ReadLine();
                            if (__tmp24Line == null)
                            {
                                __tmp24Line = "";
                            }
                            __out.Append(__tmp22Prefix);
                            __out.Append(__tmp24Line);
                            __out.Append(__tmp23Suffix);
                            __out.AppendLine(); //232:55
                        }
                    }
                    __out.Append("}"); //233:1
                    __out.AppendLine(); //233:2
                }
            }
            return __out.ToString();
        }

        public string GetCollectionConstructorParams(MetaProperty prop) //238:1
        {
            MetaCollectionType mct = prop.Type as MetaCollectionType; //239:2
            if (mct != null && mct.InnerType is MetaClass) //240:2
            {
                return "this, " + prop.JavaFullDescriptorName(); //241:3
            }
            else //242:2
            {
                return ""; //243:3
            }
        }

        public string GenerateExpression(MetaExpression expr) //248:1
        {
            StringBuilder __out = new StringBuilder();
            var __tmp1 = expr; //249:10
            if (expr is MetaBracketExpression) //250:2
            {
                __out.Append("("); //250:33
                __out.Append(GenerateExpression(((MetaBracketExpression)expr).Expression));
                __out.Append(")"); //250:71
            }
            else if (expr is MetaThisExpression) //251:2
            {
                __out.Append("(("); //251:30
                __out.Append(((MetaType)ModelCompilerContext.Current.ResolutionProvider.GetCurrentTypeScopeOf((ModelObject)((MetaThisExpression)expr))).JavaName());
                __out.Append(")this)"); //251:145
            }
            else if (expr is MetaNullExpression) //252:2
            {
                __out.Append("null"); //252:30
            }
            else if (expr is MetaTypeAsExpression) //253:2
            {
                __out.Append("metadslx.core.ModelUtils.as("); //253:32
                __out.Append(((MetaTypeAsExpression)expr).TypeReference.JavaName());
                __out.Append(".class,"); //253:91
                __out.Append(GenerateExpression(((MetaTypeAsExpression)expr).Expression));
                __out.Append(")"); //253:135
            }
            else if (expr is MetaTypeCastExpression) //254:2
            {
                __out.Append("("); //254:34
                __out.Append(((MetaTypeCastExpression)expr).TypeReference.JavaName());
                __out.Append(")"); //254:66
                __out.Append(GenerateExpression(((MetaTypeCastExpression)expr).Expression));
            }
            else if (expr is MetaTypeCheckExpression) //255:2
            {
                __out.Append(GenerateExpression(((MetaTypeCheckExpression)expr).Expression));
                __out.Append(" instanceof "); //255:72
                __out.Append(((MetaTypeCheckExpression)expr).TypeReference.JavaName());
            }
            else if (expr is MetaTypeOfExpression) //256:2
            {
                __out.Append(GenerateTypeOf(((MetaTypeOfExpression)expr)));
            }
            else if (expr is MetaConditionalExpression) //257:2
            {
                __out.Append(GenerateExpression(((MetaConditionalExpression)expr).Condition));
                __out.Append(" ? "); //257:73
                __out.Append(GenerateExpression(((MetaConditionalExpression)expr).Then));
                __out.Append(" : "); //257:107
                __out.Append(GenerateExpression(((MetaConditionalExpression)expr).Else));
            }
            else if (expr is MetaConstantExpression) //258:2
            {
                __out.Append(GetJavaValue(((MetaConstantExpression)expr).Value));
            }
            else if (expr is MetaIdentifierExpression) //259:2
            {
                __out.Append(GenerateIdentifierExpression(((MetaIdentifierExpression)expr)));
            }
            else if (expr is MetaMemberAccessExpression) //260:2
            {
                __out.Append(GenerateExpression(((MetaMemberAccessExpression)expr).Expression));
                __out.Append(".get"); //260:75
                __out.Append(((MetaMemberAccessExpression)expr).Name);
                __out.Append("()"); //260:90
            }
            else if (expr is MetaFunctionCallExpression) //261:2
            {
                __out.Append(GenerateFunctionCall(((MetaFunctionCallExpression)expr)));
            }
            else if (expr is MetaIndexerExpression) //262:2
            {
                __out.Append(GenerateIndexerCall(((MetaIndexerExpression)expr)));
            }
            else if (expr is MetaOperatorExpression) //263:2
            {
                __out.Append(GenerateOperator(((MetaOperatorExpression)expr)));
            }
            else if (expr is MetaNewExpression) //264:2
            {
                __out.Append(((MetaNewExpression)expr).TypeReference.JavaFullFactoryMethodName());
                __out.Append("("); //264:77
                __out.Append(GenerateNewPropertyInitializers(((MetaNewExpression)expr)));
                __out.Append(")"); //264:117
            }
            else if (expr is MetaNewCollectionExpression) //265:2
            {
                __out.Append("new java.util.ArrayList<metadslx.core.Lazy<Object>>() { "); //265:39
                __out.Append(GenerateNewCollectionValues(((MetaNewCollectionExpression)expr)));
                __out.Append(" }"); //265:130
            }
            else //266:2
            {
                __out.Append("***unknown expression type***"); //266:11
                __out.AppendLine(); //266:40
            }//267:2
            return __out.ToString();
        }

        public string GenerateIdentifierExpression(MetaIdentifierExpression expr) //270:1
        {
            StringBuilder __out = new StringBuilder();
            if (expr.Definition is MetaProperty) //271:2
            {
                string __tmp1Prefix = "(("; //272:1
                string __tmp2Suffix = "()"; //272:137
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(((MetaType)ModelCompilerContext.Current.ResolutionProvider.GetCurrentTypeScopeOf((ModelObject)expr)).JavaName());
                using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                {
                    bool __tmp3_first = true;
                    while(__tmp3_first || !__tmp3Reader.EndOfStream)
                    {
                        __tmp3_first = false;
                        string __tmp3Line = __tmp3Reader.ReadLine();
                        if (__tmp3Line == null)
                        {
                            __tmp3Line = "";
                        }
                        __out.Append(__tmp1Prefix);
                        __out.Append(__tmp3Line);
                    }
                }
                string __tmp4Line = ")this).get"; //272:116
                __out.Append(__tmp4Line);
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(expr.Name);
                using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                {
                    bool __tmp5_first = true;
                    while(__tmp5_first || !__tmp5Reader.EndOfStream)
                    {
                        __tmp5_first = false;
                        string __tmp5Line = __tmp5Reader.ReadLine();
                        if (__tmp5Line == null)
                        {
                            __tmp5Line = "";
                        }
                        __out.Append(__tmp5Line);
                        __out.Append(__tmp2Suffix);
                    }
                }
            }
            else //273:2
            {
                string __tmp6Prefix = string.Empty;
                string __tmp7Suffix = string.Empty;
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(expr.Name);
                using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
                {
                    bool __tmp8_first = true;
                    while(__tmp8_first || !__tmp8Reader.EndOfStream)
                    {
                        __tmp8_first = false;
                        string __tmp8Line = __tmp8Reader.ReadLine();
                        if (__tmp8Line == null)
                        {
                            __tmp8Line = "";
                        }
                        __out.Append(__tmp6Prefix);
                        __out.Append(__tmp8Line);
                        __out.Append(__tmp7Suffix);
                    }
                }
            }
            return __out.ToString();
        }

        public bool SameFunction(MetaGlobalFunction mfunc1, MetaGlobalFunction mfunc2) //278:1
        {
            return mfunc1.Name == mfunc2.Name && ModelCompilerContext.Current.TypeProvider.Equals((ModelObject)mfunc1.Type, (ModelObject)mfunc2.Type); //279:2
        }

        public string GenerateFunctionCall(MetaFunctionCallExpression call) //282:1
        {
            StringBuilder __out = new StringBuilder();
            if (call.Definition is MetaGlobalFunction && SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.TypeOf)) //283:2
            {
                __out.Append(GenerateTypeOf(call.Arguments[0]));
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.GetValueType)) //284:2
            {
                __out.Append("ModelCompilerContext.current().getTypeProvider().getTypeOf("); //284:89
                __out.Append(GenerateCallArguments(call, ""));
                __out.Append(")"); //284:181
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.GetReturnType)) //285:2
            {
                __out.Append("ModelCompilerContext.current().getTypeProvider().getReturnTypeOf("); //285:90
                __out.Append(GenerateCallArguments(call, "(ModelObject)"));
                __out.Append(")"); //285:201
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.CurrentType)) //286:2
            {
                __out.Append("ModelCompilerContext.current().getResolutionProvider().getCurrentTypeScopeOf("); //286:88
                __out.Append(GenerateCallArguments(call, "(ModelObject)"));
                __out.Append(")"); //286:211
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.TypeCheck)) //287:2
            {
                __out.Append("ModelCompilerContext.current().getTypeProvider().typeCheck("); //287:86
                __out.Append(GenerateCallArguments(call, "(ModelObject)"));
                __out.Append(")"); //287:191
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.Balance)) //288:2
            {
                __out.Append("ModelCompilerContext.current().getTypeProvider().balance("); //288:84
                __out.Append(GenerateCallArguments(call, "(ModelObject)"));
                __out.Append(")"); //288:187
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.Resolve1)) //289:2
            {
                __out.Append("ModelCompilerContext.current().getResolutionProvider().resolve(java.util.Arrays.asList(new metadslx.core.ModelObject"); //289:85
                __out.Append("[]");
                __out.Append(" { ModelCompilerContext.current().getResolutionProvider().getCurrentScope(this) }), ResolveKind.NameOrType, "); //289:207
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(", new ResolutionInfo(), ResolveFlags.All)"); //289:354
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.Resolve2)) //290:2
            {
                __out.Append("ModelCompilerContext.current().getResolutionProvider().resolve(java.util.Arrays.asList(new metadslx.core.ModelObject"); //290:85
                __out.Append("[]");
                __out.Append(" { (ModelObject)"); //290:207
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(" }), ResolveKind.NameOrType, "); //290:262
                __out.Append(GenerateExpression(call.Arguments[1]));
                __out.Append(", new ResolutionInfo(), ResolveFlags.All)"); //290:330
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.ResolveType1)) //291:2
            {
                __out.Append("ModelCompilerContext.current().getResolutionProvider().resolve(java.util.Arrays.asList(new metadslx.core.ModelObject"); //291:89
                __out.Append("[]");
                __out.Append(" { ModelCompilerContext.current().getResolutionProvider().getCurrentScope(this) }), ResolveKind.Type, "); //291:211
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(", new ResolutionInfo(), ResolveFlags.All)"); //291:352
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.ResolveType2)) //292:2
            {
                __out.Append("ModelCompilerContext.current().getResolutionProvider().resolve(java.util.Arrays.asList(new metadslx.core.ModelObject"); //292:89
                __out.Append("[]");
                __out.Append(" { (ModelObject)"); //292:211
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(" }), ResolveKind.Type, "); //292:266
                __out.Append(GenerateExpression(call.Arguments[1]));
                __out.Append(", new ResolutionInfo(), ResolveFlags.All)"); //292:328
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.ResolveName1)) //293:2
            {
                __out.Append("ModelCompilerContext.current().getResolutionProvider().resolve(java.util.Arrays.asList(new metadslx.core.ModelObject"); //293:89
                __out.Append("[]");
                __out.Append(" { ModelCompilerContext.current().getResolutionProvider().getCurrentScope(this) }), ResolveKind.Name, "); //293:211
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(", new ResolutionInfo(), ResolveFlags.All)"); //293:352
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.ResolveName2)) //294:2
            {
                __out.Append("ModelCompilerContext.current().getResolutionProvider().resolve(java.util.Arrays.asList(new metadslx.core.ModelObject"); //294:89
                __out.Append("[]");
                __out.Append(" { (ModelObject)"); //294:211
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(" }), ResolveKind.Name, "); //294:266
                __out.Append(GenerateExpression(call.Arguments[1]));
                __out.Append(", new ResolutionInfo(), ResolveFlags.All)"); //294:328
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.Bind1)) //295:2
            {
                __out.Append("ModelCompilerContext.current().getBindingProvider().bind(this, java.util.Arrays.asList(new metadslx.core.ModelObject"); //295:82
                __out.Append("[]");
                __out.Append(" { (ModelObject)"); //295:204
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(" }), new BindingInfo())"); //295:259
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.Bind2)) //296:2
            {
                __out.Append("ModelCompilerContext.current().getBindingProvider().bind(this, "); //296:82
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(", new BindingInfo())"); //296:184
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.Bind3)) //297:2
            {
                __out.Append("ModelCompilerContext.current().getBindingProvider().bind((ModelObject)"); //297:82
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(", java.util.Arrays.asList(new metadslx.core.ModelObject"); //297:191
                __out.Append("[]");
                __out.Append(" { (ModelObject)"); //297:252
                __out.Append(GenerateExpression(call.Arguments[1]));
                __out.Append(" }), new BindingInfo())"); //297:307
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.Bind4)) //298:2
            {
                __out.Append("ModelCompilerContext.current().getBindingProvider().bind((ModelObject)"); //298:82
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(", "); //298:191
                __out.Append(GenerateExpression(call.Arguments[1]));
                __out.Append(", new BindingInfo())"); //298:232
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.SelectOfType1)) //299:2
            {
                __out.Append("java.util.Arrays.asList(new Object"); //299:90
                __out.Append("[]");
                __out.Append(" { "); //299:130
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(" }).stream().filter(e -> ModelCompilerContext.current().getTypeProvider().getTypeOf(e) instanceof "); //299:172
                __out.Append(GetTypeName(call.Arguments[1]));
                __out.Append(").collect(java.util.stream.Collectors.toList())"); //299:302
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.SelectOfType2)) //300:2
            {
                __out.Append("("); //300:90
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(").stream().filter(e -> ModelCompilerContext.current().getTypeProvider().getTypeOf(e) instanceof "); //300:130
                __out.Append(GetTypeName(call.Arguments[1]));
                __out.Append(").collect(java.util.stream.Collectors.toList())"); //300:258
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.SelectOfName1)) //301:2
            {
                __out.Append("java.util.Arrays.asList(new Object"); //301:90
                __out.Append("[]");
                __out.Append(" { "); //301:130
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(" }).stream().filter(e -> ModelCompilerContext.current().getNameProvider().getNameOf((ModelObject)e) == "); //301:172
                __out.Append(GenerateExpression(call.Arguments[1]));
                __out.Append(").collect(java.util.stream.Collectors.toList())"); //301:314
            }
            else if (SameFunction((MetaGlobalFunction)call.Definition, MetaInstance.SelectOfName2)) //302:2
            {
                __out.Append("("); //302:90
                __out.Append(GenerateExpression(call.Arguments[0]));
                __out.Append(").stream().filter(e -> ModelCompilerContext.current().getNameProvider().getNameOf((ModelObject)e) == "); //302:130
                __out.Append(GenerateExpression(call.Arguments[1]));
                __out.Append(").collect(java.util.stream.Collectors.toList())"); //302:270
            }
            else //303:2
            {
                __out.Append(GenerateExpression(call.Expression));
                __out.Append("("); //303:44
                __out.Append(GenerateCallArguments(call, ""));
                __out.Append(")"); //303:78
            }
            return __out.ToString();
        }

        public string GenerateIndexerCall(MetaIndexerExpression call) //307:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty; 
            string __tmp2Suffix = string.Empty; 
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(GenerateExpression(call.Expression));
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                }
            }
            StringBuilder __tmp4 = new StringBuilder();
            __tmp4.Append("[");
            using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
            {
                bool __tmp4_first = true;
                while(__tmp4_first || !__tmp4Reader.EndOfStream)
                {
                    __tmp4_first = false;
                    string __tmp4Line = __tmp4Reader.ReadLine();
                    if (__tmp4Line == null)
                    {
                        __tmp4Line = "";
                    }
                    __out.Append(__tmp4Line);
                }
            }
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(GenerateCallArguments(call, ""));
            using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
            {
                bool __tmp5_first = true;
                while(__tmp5_first || !__tmp5Reader.EndOfStream)
                {
                    __tmp5_first = false;
                    string __tmp5Line = __tmp5Reader.ReadLine();
                    if (__tmp5Line == null)
                    {
                        __tmp5Line = "";
                    }
                    __out.Append(__tmp5Line);
                }
            }
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append("]");
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp2Suffix);
                }
            }
            return __out.ToString();
        }

        public string GenerateTypeOf(object expr) //311:1
        {
            StringBuilder __out = new StringBuilder();
            var __tmp1 = expr; //312:9
            if (expr is MetaPrimitiveType) //313:2
            {
                var __tmp2 = ((MetaPrimitiveType)expr).Name; //314:10
                __out.Append("	"); //315:1
                if (__tmp2 == "*none*") //315:3
                {
                    __out.Append("MetaInstance.None"); //315:18
                    __out.Append("	"); //316:1
                }
                else if (__tmp2 == "*error*") //316:3
                {
                    __out.Append("MetaInstance.Error"); //316:19
                    __out.Append("	"); //317:1
                }
                else if (__tmp2 == "*any*") //317:3
                {
                    __out.Append("MetaInstance.Any"); //317:17
                    __out.Append("	"); //318:1
                }
                else if (__tmp2 == "object") //318:3
                {
                    __out.Append("MetaInstance.Object"); //318:18
                    __out.Append("	"); //319:1
                }
                else if (__tmp2 == "string") //319:3
                {
                    __out.Append("MetaInstance.String"); //319:18
                    __out.Append("	"); //320:1
                }
                else if (__tmp2 == "int") //320:3
                {
                    __out.Append("MetaInstance.Int"); //320:15
                    __out.Append("	"); //321:1
                }
                else if (__tmp2 == "long") //321:3
                {
                    __out.Append("MetaInstance.Long"); //321:16
                    __out.Append("	"); //322:1
                }
                else if (__tmp2 == "float") //322:3
                {
                    __out.Append("MetaInstance.Float"); //322:17
                    __out.Append("	"); //323:1
                }
                else if (__tmp2 == "double") //323:3
                {
                    __out.Append("MetaInstance.Double"); //323:18
                    __out.Append("	"); //324:1
                }
                else if (__tmp2 == "byte") //324:3
                {
                    __out.Append("MetaInstance.Byte"); //324:16
                    __out.Append("	"); //325:1
                }
                else if (__tmp2 == "bool") //325:3
                {
                    __out.Append("MetaInstance.Bool"); //325:16
                    __out.Append("	"); //326:1
                }
                else if (__tmp2 == "void") //326:3
                {
                    __out.Append("MetaInstance.Void"); //326:16
                    __out.Append("	"); //327:1
                }
                else if (__tmp2 == "ModelObject") //327:3
                {
                    __out.Append("MetaInstance.ModelObject"); //327:23
                    __out.Append("	"); //328:1
                }
                else if (__tmp2 == "ModelObjectList") //328:3
                {
                    __out.Append("MetaInstance.ModelObjectList"); //328:27
                }//329:3
            }
            else if (expr is MetaTypeOfExpression) //330:2
            {
                __out.Append(GenerateTypeOf(((MetaTypeOfExpression)expr).TypeReference));
            }
            else if (expr is MetaClass) //331:2
            {
                __out.Append(((MetaClass)expr).JavaFullDescriptorName());
                __out.Append(".getMetaClass()"); //331:52
            }
            else if (expr is MetaCollectionType) //332:2
            {
                __out.Append(((MetaCollectionType)expr).JavaFullName());
            }
            else //333:2
            {
                __out.Append("***error***"); //333:11
            }//334:2
            return __out.ToString();
        }

        public string GenerateCallArguments(MetaBoundExpression call, string prefix) //337:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop21_results = 
                (from __loop21_var1 in __Enumerate((call).GetEnumerator()) //338:7
                from arg in __Enumerate((__loop21_var1.Arguments).GetEnumerator()) //338:13
                select new { __loop21_var1 = __loop21_var1, arg = arg}
                ).ToList(); //338:2
            int __loop21_iteration = 0;
            string delim = ""; //338:28
            foreach (var __tmp1 in __loop21_results)
            {
                ++__loop21_iteration;
                if (__loop21_iteration >= 2) //338:47
                {
                    delim = ", "; //338:47
                }
                var __loop21_var1 = __tmp1.__loop21_var1;
                var arg = __tmp1.arg;
                string __tmp2Prefix = string.Empty; 
                string __tmp3Suffix = string.Empty; 
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(delim);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                    }
                }
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(prefix);
                using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                {
                    bool __tmp5_first = true;
                    while(__tmp5_first || !__tmp5Reader.EndOfStream)
                    {
                        __tmp5_first = false;
                        string __tmp5Line = __tmp5Reader.ReadLine();
                        if (__tmp5Line == null)
                        {
                            __tmp5Line = "";
                        }
                        __out.Append(__tmp5Line);
                    }
                }
                StringBuilder __tmp6 = new StringBuilder();
                __tmp6.Append(GenerateExpression(arg));
                using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
                {
                    bool __tmp6_first = true;
                    while(__tmp6_first || !__tmp6Reader.EndOfStream)
                    {
                        __tmp6_first = false;
                        string __tmp6Line = __tmp6Reader.ReadLine();
                        if (__tmp6Line == null)
                        {
                            __tmp6Line = "";
                        }
                        __out.Append(__tmp6Line);
                        __out.Append(__tmp3Suffix);
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateOperator(MetaOperatorExpression expr) //343:1
        {
            StringBuilder __out = new StringBuilder();
            var __tmp1 = expr; //344:10
            if (expr is MetaUnaryExpression) //345:2
            {
                if (((MetaUnaryExpression)expr) is MetaPostIncrementAssignExpression || ((MetaUnaryExpression)expr) is MetaPostDecrementAssignExpression) //346:3
                {
                    string __tmp2Prefix = string.Empty; 
                    string __tmp3Suffix = string.Empty; 
                    StringBuilder __tmp4 = new StringBuilder();
                    __tmp4.Append(GenerateExpression(((MetaUnaryExpression)expr).Expression));
                    using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                    {
                        bool __tmp4_first = true;
                        while(__tmp4_first || !__tmp4Reader.EndOfStream)
                        {
                            __tmp4_first = false;
                            string __tmp4Line = __tmp4Reader.ReadLine();
                            if (__tmp4Line == null)
                            {
                                __tmp4Line = "";
                            }
                            __out.Append(__tmp2Prefix);
                            __out.Append(__tmp4Line);
                        }
                    }
                    StringBuilder __tmp5 = new StringBuilder();
                    __tmp5.Append(GetJavaOperator(((MetaUnaryExpression)expr)));
                    using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                    {
                        bool __tmp5_first = true;
                        while(__tmp5_first || !__tmp5Reader.EndOfStream)
                        {
                            __tmp5_first = false;
                            string __tmp5Line = __tmp5Reader.ReadLine();
                            if (__tmp5Line == null)
                            {
                                __tmp5Line = "";
                            }
                            __out.Append(__tmp5Line);
                            __out.Append(__tmp3Suffix);
                        }
                    }
                }
                else //348:3
                {
                    string __tmp6Prefix = string.Empty; 
                    string __tmp7Suffix = string.Empty; 
                    StringBuilder __tmp8 = new StringBuilder();
                    __tmp8.Append(GetJavaOperator(((MetaUnaryExpression)expr)));
                    using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
                    {
                        bool __tmp8_first = true;
                        while(__tmp8_first || !__tmp8Reader.EndOfStream)
                        {
                            __tmp8_first = false;
                            string __tmp8Line = __tmp8Reader.ReadLine();
                            if (__tmp8Line == null)
                            {
                                __tmp8Line = "";
                            }
                            __out.Append(__tmp6Prefix);
                            __out.Append(__tmp8Line);
                        }
                    }
                    StringBuilder __tmp9 = new StringBuilder();
                    __tmp9.Append(GenerateExpression(((MetaUnaryExpression)expr).Expression));
                    using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
                    {
                        bool __tmp9_first = true;
                        while(__tmp9_first || !__tmp9Reader.EndOfStream)
                        {
                            __tmp9_first = false;
                            string __tmp9Line = __tmp9Reader.ReadLine();
                            if (__tmp9Line == null)
                            {
                                __tmp9Line = "";
                            }
                            __out.Append(__tmp9Line);
                            __out.Append(__tmp7Suffix);
                        }
                    }
                }
            }
            else if (expr is MetaBinaryExpression) //351:2
            {
                string __tmp10Prefix = string.Empty; 
                string __tmp11Suffix = string.Empty; 
                StringBuilder __tmp12 = new StringBuilder();
                __tmp12.Append(GenerateExpression(((MetaBinaryExpression)expr).Left));
                using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
                {
                    bool __tmp12_first = true;
                    while(__tmp12_first || !__tmp12Reader.EndOfStream)
                    {
                        __tmp12_first = false;
                        string __tmp12Line = __tmp12Reader.ReadLine();
                        if (__tmp12Line == null)
                        {
                            __tmp12Line = "";
                        }
                        __out.Append(__tmp10Prefix);
                        __out.Append(__tmp12Line);
                    }
                }
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(GetJavaOperator(((MetaBinaryExpression)expr)));
                using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
                {
                    bool __tmp13_first = true;
                    while(__tmp13_first || !__tmp13Reader.EndOfStream)
                    {
                        __tmp13_first = false;
                        string __tmp13Line = __tmp13Reader.ReadLine();
                        if (__tmp13Line == null)
                        {
                            __tmp13Line = "";
                        }
                        __out.Append(__tmp13Line);
                    }
                }
                StringBuilder __tmp14 = new StringBuilder();
                __tmp14.Append(GenerateExpression(((MetaBinaryExpression)expr).Right));
                using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                {
                    bool __tmp14_first = true;
                    while(__tmp14_first || !__tmp14Reader.EndOfStream)
                    {
                        __tmp14_first = false;
                        string __tmp14Line = __tmp14Reader.ReadLine();
                        if (__tmp14Line == null)
                        {
                            __tmp14Line = "";
                        }
                        __out.Append(__tmp14Line);
                        __out.Append(__tmp11Suffix);
                    }
                }
            }//353:2
            return __out.ToString();
        }

        public string GenerateNewPropertyInitializers(MetaNewExpression expr) //356:1
        {
            StringBuilder __out = new StringBuilder();
            if ((from __loop22_var1 in __Enumerate((expr).GetEnumerator()) //357:14
            from pi in __Enumerate((__loop22_var1.PropertyInitializers).GetEnumerator()) //357:20
            select new { __loop22_var1 = __loop22_var1, pi = pi}
            ).GetEnumerator().MoveNext()) //357:2
            {
                string __tmp1Prefix = "java.util.Arrays.asList(new metadslx.core.ModelPropertyInitializer"; //358:1
                string __tmp2Suffix = " {"; //358:73
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append("[]");
                using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                {
                    bool __tmp3_first = true;
                    while(__tmp3_first || !__tmp3Reader.EndOfStream)
                    {
                        __tmp3_first = false;
                        string __tmp3Line = __tmp3Reader.ReadLine();
                        if (__tmp3Line == null)
                        {
                            __tmp3Line = "";
                        }
                        __out.Append(__tmp1Prefix);
                        __out.Append(__tmp3Line);
                        __out.Append(__tmp2Suffix);
                    }
                }
                var __loop23_results = 
                    (from __loop23_var1 in __Enumerate((expr).GetEnumerator()) //359:7
                    from pi in __Enumerate((__loop23_var1.PropertyInitializers).GetEnumerator()) //359:13
                    select new { __loop23_var1 = __loop23_var1, pi = pi}
                    ).ToList(); //359:2
                int __loop23_iteration = 0;
                string delim = ""; //359:38
                foreach (var __tmp4 in __loop23_results)
                {
                    ++__loop23_iteration;
                    if (__loop23_iteration >= 2) //359:57
                    {
                        delim = ", "; //359:57
                    }
                    var __loop23_var1 = __tmp4.__loop23_var1;
                    var pi = __tmp4.pi;
                    string __tmp5Prefix = string.Empty; 
                    string __tmp6Suffix = ", true))"; //360:153
                    StringBuilder __tmp7 = new StringBuilder();
                    __tmp7.Append(delim);
                    using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
                    {
                        bool __tmp7_first = true;
                        while(__tmp7_first || !__tmp7Reader.EndOfStream)
                        {
                            __tmp7_first = false;
                            string __tmp7Line = __tmp7Reader.ReadLine();
                            if (__tmp7Line == null)
                            {
                                __tmp7Line = "";
                            }
                            __out.Append(__tmp5Prefix);
                            __out.Append(__tmp7Line);
                        }
                    }
                    string __tmp8Line = "new metadslx.core.ModelPropertyInitializer("; //360:8
                    __out.Append(__tmp8Line);
                    StringBuilder __tmp9 = new StringBuilder();
                    __tmp9.Append(pi.Property.JavaFullDescriptorName());
                    using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
                    {
                        bool __tmp9_first = true;
                        while(__tmp9_first || !__tmp9Reader.EndOfStream)
                        {
                            __tmp9_first = false;
                            string __tmp9Line = __tmp9Reader.ReadLine();
                            if (__tmp9Line == null)
                            {
                                __tmp9Line = "";
                            }
                            __out.Append(__tmp9Line);
                        }
                    }
                    string __tmp10Line = ", metadslx.core.Lazy.create(() -> "; //360:89
                    __out.Append(__tmp10Line);
                    StringBuilder __tmp11 = new StringBuilder();
                    __tmp11.Append(GenerateExpression(pi.Value));
                    using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                    {
                        bool __tmp11_first = true;
                        while(__tmp11_first || !__tmp11Reader.EndOfStream)
                        {
                            __tmp11_first = false;
                            string __tmp11Line = __tmp11Reader.ReadLine();
                            if (__tmp11Line == null)
                            {
                                __tmp11Line = "";
                            }
                            __out.Append(__tmp11Line);
                            __out.Append(__tmp6Suffix);
                        }
                    }
                }
                __out.Append("})"); //362:1
            }
            return __out.ToString();
        }

        public string GenerateNewCollectionValues(MetaNewCollectionExpression expr) //366:1
        {
            StringBuilder __out = new StringBuilder();
            var __loop24_results = 
                (from __loop24_var1 in __Enumerate((expr).GetEnumerator()) //367:7
                from v in __Enumerate((__loop24_var1.Values).GetEnumerator()) //367:13
                select new { __loop24_var1 = __loop24_var1, v = v}
                ).ToList(); //367:2
            int __loop24_iteration = 0;
            string delim = ""; //367:23
            foreach (var __tmp1 in __loop24_results)
            {
                ++__loop24_iteration;
                if (__loop24_iteration >= 2) //367:42
                {
                    delim = ", \n"; //367:42
                }
                var __loop24_var1 = __tmp1.__loop24_var1;
                var v = __tmp1.v;
                string __tmp2Prefix = string.Empty; 
                string __tmp3Suffix = string.Empty; 
                StringBuilder __tmp4 = new StringBuilder();
                __tmp4.Append(delim);
                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                {
                    bool __tmp4_first = true;
                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                    {
                        __tmp4_first = false;
                        string __tmp4Line = __tmp4Reader.ReadLine();
                        if (__tmp4Line == null)
                        {
                            __tmp4Line = "";
                        }
                        __out.Append(__tmp2Prefix);
                        __out.Append(__tmp4Line);
                    }
                }
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(GenerateExpression(v));
                using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                {
                    bool __tmp5_first = true;
                    while(__tmp5_first || !__tmp5Reader.EndOfStream)
                    {
                        __tmp5_first = false;
                        string __tmp5Line = __tmp5Reader.ReadLine();
                        if (__tmp5Line == null)
                        {
                            __tmp5Line = "";
                        }
                        __out.Append(__tmp5Line);
                        __out.Append(__tmp3Suffix);
                    }
                }
            }
            return __out.ToString();
        }

        public string GetJavaValue(object value) //372:1
        {
            if (value == null) //373:2
            {
                return "null"; //373:21
            }
            else if (value is bool && ((bool)value) == true) //374:2
            {
                return "true"; //374:51
            }
            else if (value is bool && ((bool)value) == false) //375:2
            {
                return "false"; //375:52
            }
            else if (value is string) //376:2
            {
                return "\"" + value.ToString() + "\""; //376:28
            }
            else if (value is MetaExpression) //377:2
            {
                return GenerateExpression((MetaExpression)value); //377:36
            }
            else //378:2
            {
                return value.ToString(); //378:7
            }
        }

        public string GetJavaIdentifier(object value) //382:1
        {
            if (value == null) //383:2
            {
                return null; //384:3
            }
            if (value is MetaConstantExpression && ((MetaConstantExpression)value).Value != null) //386:2
            {
                return ((MetaConstantExpression)value).Value.ToString(); //387:3
            }
            else if (value is string) //388:2
            {
                return value.ToString(); //389:3
            }
            else //390:2
            {
                return null; //391:3
            }
        }

        public string GetJavaOperator(MetaOperatorExpression expr) //395:1
        {
            var __tmp1 = expr; //396:9
            if (expr is MetaUnaryPlusExpression) //397:3
            {
                return "+"; //397:36
            }
            else if (expr is MetaNegateExpression) //398:3
            {
                return "-"; //398:33
            }
            else if (expr is MetaOnesComplementExpression) //399:3
            {
                return "~"; //399:41
            }
            else if (expr is MetaNotExpression) //400:3
            {
                return "!"; //400:30
            }
            else if (expr is MetaPostIncrementAssignExpression) //401:3
            {
                return "++"; //401:46
            }
            else if (expr is MetaPostDecrementAssignExpression) //402:3
            {
                return "--"; //402:46
            }
            else if (expr is MetaPreIncrementAssignExpression) //403:3
            {
                return "++"; //403:45
            }
            else if (expr is MetaPreDecrementAssignExpression) //404:3
            {
                return "--"; //404:45
            }
            else if (expr is MetaMultiplyExpression) //405:3
            {
                return "*"; //405:35
            }
            else if (expr is MetaDivideExpression) //406:3
            {
                return "/"; //406:33
            }
            else if (expr is MetaModuloExpression) //407:3
            {
                return "%"; //407:33
            }
            else if (expr is MetaAddExpression) //408:3
            {
                return "+"; //408:30
            }
            else if (expr is MetaSubtractExpression) //409:3
            {
                return "-"; //409:35
            }
            else if (expr is MetaLeftShiftExpression) //410:3
            {
                return "<<"; //410:36
            }
            else if (expr is MetaRightShiftExpression) //411:3
            {
                return ">>"; //411:37
            }
            else if (expr is MetaLessThanExpression) //412:3
            {
                return "<"; //412:35
            }
            else if (expr is MetaLessThanOrEqualExpression) //413:3
            {
                return "<="; //413:42
            }
            else if (expr is MetaGreaterThanExpression) //414:3
            {
                return ">"; //414:38
            }
            else if (expr is MetaGreaterThanOrEqualExpression) //415:3
            {
                return ">="; //415:45
            }
            else if (expr is MetaEqualExpression) //416:3
            {
                return "=="; //416:32
            }
            else if (expr is MetaNotEqualExpression) //417:3
            {
                return "!="; //417:35
            }
            else if (expr is MetaAndExpression) //418:3
            {
                return "&"; //418:30
            }
            else if (expr is MetaOrExpression) //419:3
            {
                return "|"; //419:29
            }
            else if (expr is MetaExclusiveOrExpression) //420:3
            {
                return "^"; //420:38
            }
            else if (expr is MetaAndAlsoExpression) //421:3
            {
                return "&&"; //421:34
            }
            else if (expr is MetaOrElseExpression) //422:3
            {
                return "||"; //422:33
            }
            else if (expr is MetaNullCoalescingExpression) //423:3
            {
                return "??"; //423:41
            }
            else if (expr is MetaMultiplyAssignExpression) //424:3
            {
                return "*="; //424:41
            }
            else if (expr is MetaDivideAssignExpression) //425:3
            {
                return "/="; //425:39
            }
            else if (expr is MetaModuloAssignExpression) //426:3
            {
                return "%="; //426:39
            }
            else if (expr is MetaAddAssignExpression) //427:3
            {
                return "+="; //427:36
            }
            else if (expr is MetaSubtractAssignExpression) //428:3
            {
                return "-="; //428:41
            }
            else if (expr is MetaLeftShiftAssignExpression) //429:3
            {
                return "<<="; //429:42
            }
            else if (expr is MetaRightShiftAssignExpression) //430:3
            {
                return ">>="; //430:43
            }
            else if (expr is MetaAndAssignExpression) //431:3
            {
                return "&="; //431:36
            }
            else if (expr is MetaExclusiveOrAssignExpression) //432:3
            {
                return "^="; //432:44
            }
            else if (expr is MetaOrAssignExpression) //433:3
            {
                return "|="; //433:35
            }
            else //434:3
            {
                return ""; //434:12
            }//435:2
        }

        public string GetTypeName(MetaExpression expr) //438:1
        {
            if (expr is MetaTypeOfExpression) //439:2
            {
                return ((MetaTypeOfExpression)expr).TypeReference.JavaFullName(); //439:36
            }
            else //440:2
            {
                return null; //440:7
            }
        }

        public MetaSynthetizedPropertyInitializer GetSynthetizedInitializerFor(MetaClass cls, MetaProperty prop) //444:1
        {
            MetaSynthetizedPropertyInitializer lastInit = null; //445:2
            var __loop25_results = 
                (from __loop25_var1 in __Enumerate((cls).GetEnumerator()) //446:7
                from sup in __Enumerate((__loop25_var1.GetAllSuperClasses(true)).GetEnumerator()) //446:12
                from Constructor in __Enumerate((sup.Constructor).GetEnumerator()) //446:42
                from Initializers in __Enumerate((Constructor.Initializers).GetEnumerator()) //446:55
                from init in __Enumerate((Initializers).GetEnumerator()).OfType<MetaSynthetizedPropertyInitializer>() //446:69
                select new { __loop25_var1 = __loop25_var1, sup = sup, Constructor = Constructor, Initializers = Initializers, init = init}
                ).ToList(); //446:2
            int __loop25_iteration = 0;
            foreach (var __tmp1 in __loop25_results)
            {
                ++__loop25_iteration;
                var __loop25_var1 = __tmp1.__loop25_var1;
                var sup = __tmp1.sup;
                var Constructor = __tmp1.Constructor;
                var Initializers = __tmp1.Initializers;
                var init = __tmp1.init;
                if (init.Property == prop) //447:3
                {
                    lastInit = init; //448:4
                }
            }
            return lastInit; //451:2
        }

        public string GenerateConstructorImpl(MetaModel model, MetaClass cls) //454:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "public "; //455:1
            string __tmp2Suffix = "() {"; //455:28
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(cls.JavaImplName());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //455:32
                }
            }
            var __loop26_results = 
                (from __loop26_var1 in __Enumerate((cls).GetEnumerator()) //456:8
                from prop in __Enumerate((__loop26_var1.GetAllProperties()).GetEnumerator()) //456:13
                select new { __loop26_var1 = __loop26_var1, prop = prop}
                ).ToList(); //456:3
            int __loop26_iteration = 0;
            foreach (var __tmp4 in __loop26_results)
            {
                ++__loop26_iteration;
                var __loop26_var1 = __tmp4.__loop26_var1;
                var prop = __tmp4.prop;
                MetaSynthetizedPropertyInitializer synInit = GetSynthetizedInitializerFor(cls, prop); //457:4
                if (synInit != null) //458:4
                {
                    if (prop.Kind != MetaPropertyKind.Derived) //459:5
                    {
                        if (ModelCompilerContext.Current.TypeProvider.GetTypeOf(synInit.Value) is MetaCollectionType) //460:6
                        {
                            string __tmp5Prefix = "    this.mLazySet("; //461:1
                            string __tmp6Suffix = ", true));"; //461:119
                            StringBuilder __tmp7 = new StringBuilder();
                            __tmp7.Append(prop.JavaFullDescriptorName());
                            using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
                            {
                                bool __tmp7_first = true;
                                while(__tmp7_first || !__tmp7Reader.EndOfStream)
                                {
                                    __tmp7_first = false;
                                    string __tmp7Line = __tmp7Reader.ReadLine();
                                    if (__tmp7Line == null)
                                    {
                                        __tmp7Line = "";
                                    }
                                    __out.Append(__tmp5Prefix);
                                    __out.Append(__tmp7Line);
                                }
                            }
                            string __tmp8Line = ", metadslx.core.Lazy.create(() -> "; //461:50
                            __out.Append(__tmp8Line);
                            StringBuilder __tmp9 = new StringBuilder();
                            __tmp9.Append(GenerateExpression(synInit.Value));
                            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
                            {
                                bool __tmp9_first = true;
                                while(__tmp9_first || !__tmp9Reader.EndOfStream)
                                {
                                    __tmp9_first = false;
                                    string __tmp9Line = __tmp9Reader.ReadLine();
                                    if (__tmp9Line == null)
                                    {
                                        __tmp9Line = "";
                                    }
                                    __out.Append(__tmp9Line);
                                    __out.Append(__tmp6Suffix);
                                    __out.AppendLine(); //461:128
                                }
                            }
                        }
                        else //462:6
                        {
                            string __tmp10Prefix = "    this.mLazySet("; //463:1
                            string __tmp11Suffix = ", true));"; //463:119
                            StringBuilder __tmp12 = new StringBuilder();
                            __tmp12.Append(prop.JavaFullDescriptorName());
                            using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
                            {
                                bool __tmp12_first = true;
                                while(__tmp12_first || !__tmp12Reader.EndOfStream)
                                {
                                    __tmp12_first = false;
                                    string __tmp12Line = __tmp12Reader.ReadLine();
                                    if (__tmp12Line == null)
                                    {
                                        __tmp12Line = "";
                                    }
                                    __out.Append(__tmp10Prefix);
                                    __out.Append(__tmp12Line);
                                }
                            }
                            string __tmp13Line = ", metadslx.core.Lazy.create(() -> "; //463:50
                            __out.Append(__tmp13Line);
                            StringBuilder __tmp14 = new StringBuilder();
                            __tmp14.Append(GenerateExpression(synInit.Value));
                            using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
                            {
                                bool __tmp14_first = true;
                                while(__tmp14_first || !__tmp14Reader.EndOfStream)
                                {
                                    __tmp14_first = false;
                                    string __tmp14Line = __tmp14Reader.ReadLine();
                                    if (__tmp14Line == null)
                                    {
                                        __tmp14Line = "";
                                    }
                                    __out.Append(__tmp14Line);
                                    __out.Append(__tmp11Suffix);
                                    __out.AppendLine(); //463:128
                                }
                            }
                        }
                    }
                    else //465:5
                    {
                        string __tmp15Prefix = "    this.mDerivedSet("; //466:1
                        string __tmp16Suffix = ");"; //466:96
                        StringBuilder __tmp17 = new StringBuilder();
                        __tmp17.Append(prop.JavaFullDescriptorName());
                        using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
                        {
                            bool __tmp17_first = true;
                            while(__tmp17_first || !__tmp17Reader.EndOfStream)
                            {
                                __tmp17_first = false;
                                string __tmp17Line = __tmp17Reader.ReadLine();
                                if (__tmp17Line == null)
                                {
                                    __tmp17Line = "";
                                }
                                __out.Append(__tmp15Prefix);
                                __out.Append(__tmp17Line);
                            }
                        }
                        string __tmp18Line = ", () -> "; //466:53
                        __out.Append(__tmp18Line);
                        StringBuilder __tmp19 = new StringBuilder();
                        __tmp19.Append(GenerateExpression(synInit.Value));
                        using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
                        {
                            bool __tmp19_first = true;
                            while(__tmp19_first || !__tmp19Reader.EndOfStream)
                            {
                                __tmp19_first = false;
                                string __tmp19Line = __tmp19Reader.ReadLine();
                                if (__tmp19Line == null)
                                {
                                    __tmp19Line = "";
                                }
                                __out.Append(__tmp19Line);
                                __out.Append(__tmp16Suffix);
                                __out.AppendLine(); //466:98
                            }
                        }
                    }
                }
                else //468:4
                {
                    if (prop.Type is MetaCollectionType) //469:5
                    {
                        if (prop.Kind == MetaPropertyKind.Normal || prop.Kind == MetaPropertyKind.Containment) //470:6
                        {
                            string __tmp20Prefix = "    this.mSet("; //471:1
                            string __tmp21Suffix = "));"; //471:113
                            StringBuilder __tmp22 = new StringBuilder();
                            __tmp22.Append(prop.JavaFullDescriptorName());
                            using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                            {
                                bool __tmp22_first = true;
                                while(__tmp22_first || !__tmp22Reader.EndOfStream)
                                {
                                    __tmp22_first = false;
                                    string __tmp22Line = __tmp22Reader.ReadLine();
                                    if (__tmp22Line == null)
                                    {
                                        __tmp22Line = "";
                                    }
                                    __out.Append(__tmp20Prefix);
                                    __out.Append(__tmp22Line);
                                }
                            }
                            string __tmp23Line = ", new "; //471:46
                            __out.Append(__tmp23Line);
                            StringBuilder __tmp24 = new StringBuilder();
                            __tmp24.Append(prop.Type.JavaName());
                            using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                            {
                                bool __tmp24_first = true;
                                while(__tmp24_first || !__tmp24Reader.EndOfStream)
                                {
                                    __tmp24_first = false;
                                    string __tmp24Line = __tmp24Reader.ReadLine();
                                    if (__tmp24Line == null)
                                    {
                                        __tmp24Line = "";
                                    }
                                    __out.Append(__tmp24Line);
                                }
                            }
                            string __tmp25Line = "("; //471:74
                            __out.Append(__tmp25Line);
                            StringBuilder __tmp26 = new StringBuilder();
                            __tmp26.Append(GetCollectionConstructorParams(prop));
                            using(StreamReader __tmp26Reader = new StreamReader(this.__ToStream(__tmp26.ToString())))
                            {
                                bool __tmp26_first = true;
                                while(__tmp26_first || !__tmp26Reader.EndOfStream)
                                {
                                    __tmp26_first = false;
                                    string __tmp26Line = __tmp26Reader.ReadLine();
                                    if (__tmp26Line == null)
                                    {
                                        __tmp26Line = "";
                                    }
                                    __out.Append(__tmp26Line);
                                    __out.Append(__tmp21Suffix);
                                    __out.AppendLine(); //471:116
                                }
                            }
                        }
                        else if (prop.Kind == MetaPropertyKind.Lazy) //472:6
                        {
                            string __tmp27Prefix = "    this.mLazySet("; //473:1
                            string __tmp28Suffix = "(this), true));"; //473:167
                            StringBuilder __tmp29 = new StringBuilder();
                            __tmp29.Append(prop.JavaFullDescriptorName());
                            using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
                            {
                                bool __tmp29_first = true;
                                while(__tmp29_first || !__tmp29Reader.EndOfStream)
                                {
                                    __tmp29_first = false;
                                    string __tmp29Line = __tmp29Reader.ReadLine();
                                    if (__tmp29Line == null)
                                    {
                                        __tmp29Line = "";
                                    }
                                    __out.Append(__tmp27Prefix);
                                    __out.Append(__tmp29Line);
                                }
                            }
                            string __tmp30Line = ", metadslx.core.Lazy.create(() -> "; //473:50
                            __out.Append(__tmp30Line);
                            StringBuilder __tmp31 = new StringBuilder();
                            __tmp31.Append(prop.Class.Model.JavaFullImplementationName());
                            using(StreamReader __tmp31Reader = new StreamReader(this.__ToStream(__tmp31.ToString())))
                            {
                                bool __tmp31_first = true;
                                while(__tmp31_first || !__tmp31Reader.EndOfStream)
                                {
                                    __tmp31_first = false;
                                    string __tmp31Line = __tmp31Reader.ReadLine();
                                    if (__tmp31Line == null)
                                    {
                                        __tmp31Line = "";
                                    }
                                    __out.Append(__tmp31Line);
                                }
                            }
                            string __tmp32Line = "."; //473:131
                            __out.Append(__tmp32Line);
                            StringBuilder __tmp33 = new StringBuilder();
                            __tmp33.Append(prop.Class.JavaName());
                            using(StreamReader __tmp33Reader = new StreamReader(this.__ToStream(__tmp33.ToString())))
                            {
                                bool __tmp33_first = true;
                                while(__tmp33_first || !__tmp33Reader.EndOfStream)
                                {
                                    __tmp33_first = false;
                                    string __tmp33Line = __tmp33Reader.ReadLine();
                                    if (__tmp33Line == null)
                                    {
                                        __tmp33Line = "";
                                    }
                                    __out.Append(__tmp33Line);
                                }
                            }
                            string __tmp34Line = "_"; //473:155
                            __out.Append(__tmp34Line);
                            StringBuilder __tmp35 = new StringBuilder();
                            __tmp35.Append(prop.Name);
                            using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
                            {
                                bool __tmp35_first = true;
                                while(__tmp35_first || !__tmp35Reader.EndOfStream)
                                {
                                    __tmp35_first = false;
                                    string __tmp35Line = __tmp35Reader.ReadLine();
                                    if (__tmp35Line == null)
                                    {
                                        __tmp35Line = "";
                                    }
                                    __out.Append(__tmp35Line);
                                    __out.Append(__tmp28Suffix);
                                    __out.AppendLine(); //473:182
                                }
                            }
                        }
                        else if (prop.Kind == MetaPropertyKind.Derived) //474:6
                        {
                            string __tmp36Prefix = "    this.mDerivedSet("; //475:1
                            string __tmp37Suffix = "(this));"; //475:144
                            StringBuilder __tmp38 = new StringBuilder();
                            __tmp38.Append(prop.JavaFullDescriptorName());
                            using(StreamReader __tmp38Reader = new StreamReader(this.__ToStream(__tmp38.ToString())))
                            {
                                bool __tmp38_first = true;
                                while(__tmp38_first || !__tmp38Reader.EndOfStream)
                                {
                                    __tmp38_first = false;
                                    string __tmp38Line = __tmp38Reader.ReadLine();
                                    if (__tmp38Line == null)
                                    {
                                        __tmp38Line = "";
                                    }
                                    __out.Append(__tmp36Prefix);
                                    __out.Append(__tmp38Line);
                                }
                            }
                            string __tmp39Line = ", () -> "; //475:53
                            __out.Append(__tmp39Line);
                            StringBuilder __tmp40 = new StringBuilder();
                            __tmp40.Append(prop.Class.Model.JavaFullImplementationName());
                            using(StreamReader __tmp40Reader = new StreamReader(this.__ToStream(__tmp40.ToString())))
                            {
                                bool __tmp40_first = true;
                                while(__tmp40_first || !__tmp40Reader.EndOfStream)
                                {
                                    __tmp40_first = false;
                                    string __tmp40Line = __tmp40Reader.ReadLine();
                                    if (__tmp40Line == null)
                                    {
                                        __tmp40Line = "";
                                    }
                                    __out.Append(__tmp40Line);
                                }
                            }
                            string __tmp41Line = "."; //475:108
                            __out.Append(__tmp41Line);
                            StringBuilder __tmp42 = new StringBuilder();
                            __tmp42.Append(prop.Class.JavaName());
                            using(StreamReader __tmp42Reader = new StreamReader(this.__ToStream(__tmp42.ToString())))
                            {
                                bool __tmp42_first = true;
                                while(__tmp42_first || !__tmp42Reader.EndOfStream)
                                {
                                    __tmp42_first = false;
                                    string __tmp42Line = __tmp42Reader.ReadLine();
                                    if (__tmp42Line == null)
                                    {
                                        __tmp42Line = "";
                                    }
                                    __out.Append(__tmp42Line);
                                }
                            }
                            string __tmp43Line = "_"; //475:132
                            __out.Append(__tmp43Line);
                            StringBuilder __tmp44 = new StringBuilder();
                            __tmp44.Append(prop.Name);
                            using(StreamReader __tmp44Reader = new StreamReader(this.__ToStream(__tmp44.ToString())))
                            {
                                bool __tmp44_first = true;
                                while(__tmp44_first || !__tmp44Reader.EndOfStream)
                                {
                                    __tmp44_first = false;
                                    string __tmp44Line = __tmp44Reader.ReadLine();
                                    if (__tmp44Line == null)
                                    {
                                        __tmp44Line = "";
                                    }
                                    __out.Append(__tmp44Line);
                                    __out.Append(__tmp37Suffix);
                                    __out.AppendLine(); //475:152
                                }
                            }
                        }
                        else if (prop.Kind == MetaPropertyKind.Readonly) //476:6
                        {
                            string __tmp45Prefix = "    // Init "; //477:1
                            string __tmp46Suffix = string.Empty; 
                            StringBuilder __tmp47 = new StringBuilder();
                            __tmp47.Append(prop.JavaFullDescriptorName());
                            using(StreamReader __tmp47Reader = new StreamReader(this.__ToStream(__tmp47.ToString())))
                            {
                                bool __tmp47_first = true;
                                while(__tmp47_first || !__tmp47Reader.EndOfStream)
                                {
                                    __tmp47_first = false;
                                    string __tmp47Line = __tmp47Reader.ReadLine();
                                    if (__tmp47Line == null)
                                    {
                                        __tmp47Line = "";
                                    }
                                    __out.Append(__tmp45Prefix);
                                    __out.Append(__tmp47Line);
                                }
                            }
                            string __tmp48Line = " in "; //477:44
                            __out.Append(__tmp48Line);
                            StringBuilder __tmp49 = new StringBuilder();
                            __tmp49.Append(prop.Class.Model.JavaFullImplementationName());
                            using(StreamReader __tmp49Reader = new StreamReader(this.__ToStream(__tmp49.ToString())))
                            {
                                bool __tmp49_first = true;
                                while(__tmp49_first || !__tmp49Reader.EndOfStream)
                                {
                                    __tmp49_first = false;
                                    string __tmp49Line = __tmp49Reader.ReadLine();
                                    if (__tmp49Line == null)
                                    {
                                        __tmp49Line = "";
                                    }
                                    __out.Append(__tmp49Line);
                                }
                            }
                            string __tmp50Line = "."; //477:95
                            __out.Append(__tmp50Line);
                            StringBuilder __tmp51 = new StringBuilder();
                            __tmp51.Append(cls.JavaName());
                            using(StreamReader __tmp51Reader = new StreamReader(this.__ToStream(__tmp51.ToString())))
                            {
                                bool __tmp51_first = true;
                                while(__tmp51_first || !__tmp51Reader.EndOfStream)
                                {
                                    __tmp51_first = false;
                                    string __tmp51Line = __tmp51Reader.ReadLine();
                                    if (__tmp51Line == null)
                                    {
                                        __tmp51Line = "";
                                    }
                                    __out.Append(__tmp51Line);
                                }
                            }
                            string __tmp52Line = "_"; //477:112
                            __out.Append(__tmp52Line);
                            StringBuilder __tmp53 = new StringBuilder();
                            __tmp53.Append(cls.JavaName());
                            using(StreamReader __tmp53Reader = new StreamReader(this.__ToStream(__tmp53.ToString())))
                            {
                                bool __tmp53_first = true;
                                while(__tmp53_first || !__tmp53Reader.EndOfStream)
                                {
                                    __tmp53_first = false;
                                    string __tmp53Line = __tmp53Reader.ReadLine();
                                    if (__tmp53Line == null)
                                    {
                                        __tmp53Line = "";
                                    }
                                    __out.Append(__tmp53Line);
                                    __out.Append(__tmp46Suffix);
                                    __out.AppendLine(); //477:129
                                }
                            }
                        }
                    }
                    else //479:5
                    {
                        if (prop.Kind == MetaPropertyKind.Lazy) //480:6
                        {
                            string __tmp54Prefix = "    this.mLazySet("; //481:1
                            string __tmp55Suffix = "(this), true));"; //481:156
                            StringBuilder __tmp56 = new StringBuilder();
                            __tmp56.Append(prop.JavaFullDescriptorName());
                            using(StreamReader __tmp56Reader = new StreamReader(this.__ToStream(__tmp56.ToString())))
                            {
                                bool __tmp56_first = true;
                                while(__tmp56_first || !__tmp56Reader.EndOfStream)
                                {
                                    __tmp56_first = false;
                                    string __tmp56Line = __tmp56Reader.ReadLine();
                                    if (__tmp56Line == null)
                                    {
                                        __tmp56Line = "";
                                    }
                                    __out.Append(__tmp54Prefix);
                                    __out.Append(__tmp56Line);
                                }
                            }
                            string __tmp57Line = ", metadslx.core.Lazy.create(() -> "; //481:50
                            __out.Append(__tmp57Line);
                            StringBuilder __tmp58 = new StringBuilder();
                            __tmp58.Append(model.JavaFullImplementationName());
                            using(StreamReader __tmp58Reader = new StreamReader(this.__ToStream(__tmp58.ToString())))
                            {
                                bool __tmp58_first = true;
                                while(__tmp58_first || !__tmp58Reader.EndOfStream)
                                {
                                    __tmp58_first = false;
                                    string __tmp58Line = __tmp58Reader.ReadLine();
                                    if (__tmp58Line == null)
                                    {
                                        __tmp58Line = "";
                                    }
                                    __out.Append(__tmp58Line);
                                }
                            }
                            string __tmp59Line = "."; //481:120
                            __out.Append(__tmp59Line);
                            StringBuilder __tmp60 = new StringBuilder();
                            __tmp60.Append(prop.Class.JavaName());
                            using(StreamReader __tmp60Reader = new StreamReader(this.__ToStream(__tmp60.ToString())))
                            {
                                bool __tmp60_first = true;
                                while(__tmp60_first || !__tmp60Reader.EndOfStream)
                                {
                                    __tmp60_first = false;
                                    string __tmp60Line = __tmp60Reader.ReadLine();
                                    if (__tmp60Line == null)
                                    {
                                        __tmp60Line = "";
                                    }
                                    __out.Append(__tmp60Line);
                                }
                            }
                            string __tmp61Line = "_"; //481:144
                            __out.Append(__tmp61Line);
                            StringBuilder __tmp62 = new StringBuilder();
                            __tmp62.Append(prop.Name);
                            using(StreamReader __tmp62Reader = new StreamReader(this.__ToStream(__tmp62.ToString())))
                            {
                                bool __tmp62_first = true;
                                while(__tmp62_first || !__tmp62Reader.EndOfStream)
                                {
                                    __tmp62_first = false;
                                    string __tmp62Line = __tmp62Reader.ReadLine();
                                    if (__tmp62Line == null)
                                    {
                                        __tmp62Line = "";
                                    }
                                    __out.Append(__tmp62Line);
                                    __out.Append(__tmp55Suffix);
                                    __out.AppendLine(); //481:171
                                }
                            }
                        }
                        else if (prop.Kind == MetaPropertyKind.Derived) //482:6
                        {
                            string __tmp63Prefix = "    this.mDerivedSet("; //483:1
                            string __tmp64Suffix = "(this));"; //483:133
                            StringBuilder __tmp65 = new StringBuilder();
                            __tmp65.Append(prop.JavaFullDescriptorName());
                            using(StreamReader __tmp65Reader = new StreamReader(this.__ToStream(__tmp65.ToString())))
                            {
                                bool __tmp65_first = true;
                                while(__tmp65_first || !__tmp65Reader.EndOfStream)
                                {
                                    __tmp65_first = false;
                                    string __tmp65Line = __tmp65Reader.ReadLine();
                                    if (__tmp65Line == null)
                                    {
                                        __tmp65Line = "";
                                    }
                                    __out.Append(__tmp63Prefix);
                                    __out.Append(__tmp65Line);
                                }
                            }
                            string __tmp66Line = ", () -> "; //483:53
                            __out.Append(__tmp66Line);
                            StringBuilder __tmp67 = new StringBuilder();
                            __tmp67.Append(model.JavaFullImplementationName());
                            using(StreamReader __tmp67Reader = new StreamReader(this.__ToStream(__tmp67.ToString())))
                            {
                                bool __tmp67_first = true;
                                while(__tmp67_first || !__tmp67Reader.EndOfStream)
                                {
                                    __tmp67_first = false;
                                    string __tmp67Line = __tmp67Reader.ReadLine();
                                    if (__tmp67Line == null)
                                    {
                                        __tmp67Line = "";
                                    }
                                    __out.Append(__tmp67Line);
                                }
                            }
                            string __tmp68Line = "."; //483:97
                            __out.Append(__tmp68Line);
                            StringBuilder __tmp69 = new StringBuilder();
                            __tmp69.Append(prop.Class.JavaName());
                            using(StreamReader __tmp69Reader = new StreamReader(this.__ToStream(__tmp69.ToString())))
                            {
                                bool __tmp69_first = true;
                                while(__tmp69_first || !__tmp69Reader.EndOfStream)
                                {
                                    __tmp69_first = false;
                                    string __tmp69Line = __tmp69Reader.ReadLine();
                                    if (__tmp69Line == null)
                                    {
                                        __tmp69Line = "";
                                    }
                                    __out.Append(__tmp69Line);
                                }
                            }
                            string __tmp70Line = "_"; //483:121
                            __out.Append(__tmp70Line);
                            StringBuilder __tmp71 = new StringBuilder();
                            __tmp71.Append(prop.Name);
                            using(StreamReader __tmp71Reader = new StreamReader(this.__ToStream(__tmp71.ToString())))
                            {
                                bool __tmp71_first = true;
                                while(__tmp71_first || !__tmp71Reader.EndOfStream)
                                {
                                    __tmp71_first = false;
                                    string __tmp71Line = __tmp71Reader.ReadLine();
                                    if (__tmp71Line == null)
                                    {
                                        __tmp71Line = "";
                                    }
                                    __out.Append(__tmp71Line);
                                    __out.Append(__tmp64Suffix);
                                    __out.AppendLine(); //483:141
                                }
                            }
                        }
                        else if (prop.Kind == MetaPropertyKind.Readonly) //484:6
                        {
                            string __tmp72Prefix = "    // Init "; //485:1
                            string __tmp73Suffix = string.Empty; 
                            StringBuilder __tmp74 = new StringBuilder();
                            __tmp74.Append(prop.JavaFullDescriptorName());
                            using(StreamReader __tmp74Reader = new StreamReader(this.__ToStream(__tmp74.ToString())))
                            {
                                bool __tmp74_first = true;
                                while(__tmp74_first || !__tmp74Reader.EndOfStream)
                                {
                                    __tmp74_first = false;
                                    string __tmp74Line = __tmp74Reader.ReadLine();
                                    if (__tmp74Line == null)
                                    {
                                        __tmp74Line = "";
                                    }
                                    __out.Append(__tmp72Prefix);
                                    __out.Append(__tmp74Line);
                                }
                            }
                            string __tmp75Line = " in "; //485:44
                            __out.Append(__tmp75Line);
                            StringBuilder __tmp76 = new StringBuilder();
                            __tmp76.Append(model.JavaFullImplementationName());
                            using(StreamReader __tmp76Reader = new StreamReader(this.__ToStream(__tmp76.ToString())))
                            {
                                bool __tmp76_first = true;
                                while(__tmp76_first || !__tmp76Reader.EndOfStream)
                                {
                                    __tmp76_first = false;
                                    string __tmp76Line = __tmp76Reader.ReadLine();
                                    if (__tmp76Line == null)
                                    {
                                        __tmp76Line = "";
                                    }
                                    __out.Append(__tmp76Line);
                                }
                            }
                            string __tmp77Line = "."; //485:84
                            __out.Append(__tmp77Line);
                            StringBuilder __tmp78 = new StringBuilder();
                            __tmp78.Append(cls.JavaName());
                            using(StreamReader __tmp78Reader = new StreamReader(this.__ToStream(__tmp78.ToString())))
                            {
                                bool __tmp78_first = true;
                                while(__tmp78_first || !__tmp78Reader.EndOfStream)
                                {
                                    __tmp78_first = false;
                                    string __tmp78Line = __tmp78Reader.ReadLine();
                                    if (__tmp78Line == null)
                                    {
                                        __tmp78Line = "";
                                    }
                                    __out.Append(__tmp78Line);
                                }
                            }
                            string __tmp79Line = "_"; //485:101
                            __out.Append(__tmp79Line);
                            StringBuilder __tmp80 = new StringBuilder();
                            __tmp80.Append(cls.JavaName());
                            using(StreamReader __tmp80Reader = new StreamReader(this.__ToStream(__tmp80.ToString())))
                            {
                                bool __tmp80_first = true;
                                while(__tmp80_first || !__tmp80Reader.EndOfStream)
                                {
                                    __tmp80_first = false;
                                    string __tmp80Line = __tmp80Reader.ReadLine();
                                    if (__tmp80Line == null)
                                    {
                                        __tmp80Line = "";
                                    }
                                    __out.Append(__tmp80Line);
                                    __out.Append(__tmp73Suffix);
                                    __out.AppendLine(); //485:118
                                }
                            }
                        }
                    }
                }
            }
            var __loop27_results = 
                (from __loop27_var1 in __Enumerate((cls).GetEnumerator()) //490:8
                from sup in __Enumerate((__loop27_var1.GetAllSuperClasses(true)).GetEnumerator()) //490:13
                from Constructor in __Enumerate((sup.Constructor).GetEnumerator()) //490:43
                from Initializers in __Enumerate((Constructor.Initializers).GetEnumerator()) //490:56
                from init in __Enumerate((Initializers).GetEnumerator()).OfType<MetaInheritedPropertyInitializer>() //490:70
                select new { __loop27_var1 = __loop27_var1, sup = sup, Constructor = Constructor, Initializers = Initializers, init = init}
                ).ToList(); //490:3
            int __loop27_iteration = 0;
            foreach (var __tmp81 in __loop27_results)
            {
                ++__loop27_iteration;
                var __loop27_var1 = __tmp81.__loop27_var1;
                var sup = __tmp81.sup;
                var Constructor = __tmp81.Constructor;
                var Initializers = __tmp81.Initializers;
                var init = __tmp81.init;
                if (init.Object != null && init.Property != null) //491:4
                {
                    string __tmp82Prefix = "    this.mLazySetChild("; //492:1
                    string __tmp83Suffix = ", true));"; //492:170
                    StringBuilder __tmp84 = new StringBuilder();
                    __tmp84.Append(init.Object.JavaFullDescriptorName());
                    using(StreamReader __tmp84Reader = new StreamReader(this.__ToStream(__tmp84.ToString())))
                    {
                        bool __tmp84_first = true;
                        while(__tmp84_first || !__tmp84Reader.EndOfStream)
                        {
                            __tmp84_first = false;
                            string __tmp84Line = __tmp84Reader.ReadLine();
                            if (__tmp84Line == null)
                            {
                                __tmp84Line = "";
                            }
                            __out.Append(__tmp82Prefix);
                            __out.Append(__tmp84Line);
                        }
                    }
                    string __tmp85Line = ", "; //492:62
                    __out.Append(__tmp85Line);
                    StringBuilder __tmp86 = new StringBuilder();
                    __tmp86.Append(init.Property.JavaFullDescriptorName());
                    using(StreamReader __tmp86Reader = new StreamReader(this.__ToStream(__tmp86.ToString())))
                    {
                        bool __tmp86_first = true;
                        while(__tmp86_first || !__tmp86Reader.EndOfStream)
                        {
                            __tmp86_first = false;
                            string __tmp86Line = __tmp86Reader.ReadLine();
                            if (__tmp86Line == null)
                            {
                                __tmp86Line = "";
                            }
                            __out.Append(__tmp86Line);
                        }
                    }
                    string __tmp87Line = ", metadslx.core.Lazy.create(() -> "; //492:104
                    __out.Append(__tmp87Line);
                    StringBuilder __tmp88 = new StringBuilder();
                    __tmp88.Append(GenerateExpression(init.Value));
                    using(StreamReader __tmp88Reader = new StreamReader(this.__ToStream(__tmp88.ToString())))
                    {
                        bool __tmp88_first = true;
                        while(__tmp88_first || !__tmp88Reader.EndOfStream)
                        {
                            __tmp88_first = false;
                            string __tmp88Line = __tmp88Reader.ReadLine();
                            if (__tmp88Line == null)
                            {
                                __tmp88Line = "";
                            }
                            __out.Append(__tmp88Line);
                            __out.Append(__tmp83Suffix);
                            __out.AppendLine(); //492:179
                        }
                    }
                }
            }
            string __tmp89Prefix = "    "; //495:1
            string __tmp90Suffix = "(this);"; //495:62
            StringBuilder __tmp91 = new StringBuilder();
            __tmp91.Append(cls.Model.JavaFullImplementationName());
            using(StreamReader __tmp91Reader = new StreamReader(this.__ToStream(__tmp91.ToString())))
            {
                bool __tmp91_first = true;
                while(__tmp91_first || !__tmp91Reader.EndOfStream)
                {
                    __tmp91_first = false;
                    string __tmp91Line = __tmp91Reader.ReadLine();
                    if (__tmp91Line == null)
                    {
                        __tmp91Line = "";
                    }
                    __out.Append(__tmp89Prefix);
                    __out.Append(__tmp91Line);
                }
            }
            string __tmp92Line = "."; //495:45
            __out.Append(__tmp92Line);
            StringBuilder __tmp93 = new StringBuilder();
            __tmp93.Append(cls.JavaName());
            using(StreamReader __tmp93Reader = new StreamReader(this.__ToStream(__tmp93.ToString())))
            {
                bool __tmp93_first = true;
                while(__tmp93_first || !__tmp93Reader.EndOfStream)
                {
                    __tmp93_first = false;
                    string __tmp93Line = __tmp93Reader.ReadLine();
                    if (__tmp93Line == null)
                    {
                        __tmp93Line = "";
                    }
                    __out.Append(__tmp93Line);
                    __out.Append(__tmp90Suffix);
                    __out.AppendLine(); //495:69
                }
            }
            var __loop28_results = 
                (from __loop28_var1 in __Enumerate((cls).GetEnumerator()) //496:11
                from prop in __Enumerate((__loop28_var1.GetAllProperties()).GetEnumerator()) //496:16
                select new { __loop28_var1 = __loop28_var1, prop = prop}
                ).ToList(); //496:6
            int __loop28_iteration = 0;
            foreach (var __tmp94 in __loop28_results)
            {
                ++__loop28_iteration;
                var __loop28_var1 = __tmp94.__loop28_var1;
                var prop = __tmp94.prop;
                if (prop.Kind == MetaPropertyKind.Readonly) //497:4
                {
                    string __tmp95Prefix = "    if (!this.mIsSet("; //498:1
                    string __tmp96Suffix = "().\");"; //498:211
                    StringBuilder __tmp97 = new StringBuilder();
                    __tmp97.Append(prop.JavaFullDescriptorName());
                    using(StreamReader __tmp97Reader = new StreamReader(this.__ToStream(__tmp97.ToString())))
                    {
                        bool __tmp97_first = true;
                        while(__tmp97_first || !__tmp97Reader.EndOfStream)
                        {
                            __tmp97_first = false;
                            string __tmp97Line = __tmp97Reader.ReadLine();
                            if (__tmp97Line == null)
                            {
                                __tmp97Line = "";
                            }
                            __out.Append(__tmp95Prefix);
                            __out.Append(__tmp97Line);
                        }
                    }
                    string __tmp98Line = ")) throw new ModelException(\"Readonly property "; //498:53
                    __out.Append(__tmp98Line);
                    StringBuilder __tmp99 = new StringBuilder();
                    __tmp99.Append(model.JavaName());
                    using(StreamReader __tmp99Reader = new StreamReader(this.__ToStream(__tmp99.ToString())))
                    {
                        bool __tmp99_first = true;
                        while(__tmp99_first || !__tmp99Reader.EndOfStream)
                        {
                            __tmp99_first = false;
                            string __tmp99Line = __tmp99Reader.ReadLine();
                            if (__tmp99Line == null)
                            {
                                __tmp99Line = "";
                            }
                            __out.Append(__tmp99Line);
                        }
                    }
                    string __tmp100Line = "."; //498:118
                    __out.Append(__tmp100Line);
                    StringBuilder __tmp101 = new StringBuilder();
                    __tmp101.Append(prop.Class.JavaName());
                    using(StreamReader __tmp101Reader = new StreamReader(this.__ToStream(__tmp101.ToString())))
                    {
                        bool __tmp101_first = true;
                        while(__tmp101_first || !__tmp101Reader.EndOfStream)
                        {
                            __tmp101_first = false;
                            string __tmp101Line = __tmp101Reader.ReadLine();
                            if (__tmp101Line == null)
                            {
                                __tmp101Line = "";
                            }
                            __out.Append(__tmp101Line);
                        }
                    }
                    string __tmp102Line = "."; //498:142
                    __out.Append(__tmp102Line);
                    StringBuilder __tmp103 = new StringBuilder();
                    __tmp103.Append(prop.Name);
                    using(StreamReader __tmp103Reader = new StreamReader(this.__ToStream(__tmp103.ToString())))
                    {
                        bool __tmp103_first = true;
                        while(__tmp103_first || !__tmp103Reader.EndOfStream)
                        {
                            __tmp103_first = false;
                            string __tmp103Line = __tmp103Reader.ReadLine();
                            if (__tmp103Line == null)
                            {
                                __tmp103Line = "";
                            }
                            __out.Append(__tmp103Line);
                        }
                    }
                    string __tmp104Line = "Property was not set in "; //498:154
                    __out.Append(__tmp104Line);
                    StringBuilder __tmp105 = new StringBuilder();
                    __tmp105.Append(cls.JavaName());
                    using(StreamReader __tmp105Reader = new StreamReader(this.__ToStream(__tmp105.ToString())))
                    {
                        bool __tmp105_first = true;
                        while(__tmp105_first || !__tmp105Reader.EndOfStream)
                        {
                            __tmp105_first = false;
                            string __tmp105Line = __tmp105Reader.ReadLine();
                            if (__tmp105Line == null)
                            {
                                __tmp105Line = "";
                            }
                            __out.Append(__tmp105Line);
                        }
                    }
                    string __tmp106Line = "_"; //498:194
                    __out.Append(__tmp106Line);
                    StringBuilder __tmp107 = new StringBuilder();
                    __tmp107.Append(cls.JavaName());
                    using(StreamReader __tmp107Reader = new StreamReader(this.__ToStream(__tmp107.ToString())))
                    {
                        bool __tmp107_first = true;
                        while(__tmp107_first || !__tmp107Reader.EndOfStream)
                        {
                            __tmp107_first = false;
                            string __tmp107Line = __tmp107Reader.ReadLine();
                            if (__tmp107Line == null)
                            {
                                __tmp107Line = "";
                            }
                            __out.Append(__tmp107Line);
                            __out.Append(__tmp96Suffix);
                            __out.AppendLine(); //498:217
                        }
                    }
                }
            }
            __out.Append("    this.mMakeDefault();"); //501:1
            __out.AppendLine(); //501:25
            __out.Append("}"); //502:1
            __out.AppendLine(); //502:2
            return __out.ToString();
        }

        public string GetReturn(MetaOperation op) //505:1
        {
            if (op.ReturnType.JavaName() == "void") //506:5
            {
                return ""; //507:3
            }
            else //508:2
            {
                return "return "; //509:3
            }
        }

        public string GenerateOperationImpl(MetaModel model, MetaOperation op, HashSet<string> generated) //513:1
        {
            StringBuilder __out = new StringBuilder();
            if (generated.Add(op.Name)) //514:2
            {
                __out.AppendLine(); //515:1
                string __tmp1Prefix = "public "; //516:1
                string __tmp2Suffix = ") {"; //516:95
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(op.ReturnType.JavaFullPublicName());
                using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                {
                    bool __tmp3_first = true;
                    while(__tmp3_first || !__tmp3Reader.EndOfStream)
                    {
                        __tmp3_first = false;
                        string __tmp3Line = __tmp3Reader.ReadLine();
                        if (__tmp3Line == null)
                        {
                            __tmp3Line = "";
                        }
                        __out.Append(__tmp1Prefix);
                        __out.Append(__tmp3Line);
                    }
                }
                string __tmp4Line = " "; //516:44
                __out.Append(__tmp4Line);
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(op.Name.ToCamelCase());
                using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                {
                    bool __tmp5_first = true;
                    while(__tmp5_first || !__tmp5Reader.EndOfStream)
                    {
                        __tmp5_first = false;
                        string __tmp5Line = __tmp5Reader.ReadLine();
                        if (__tmp5Line == null)
                        {
                            __tmp5Line = "";
                        }
                        __out.Append(__tmp5Line);
                    }
                }
                string __tmp6Line = "("; //516:68
                __out.Append(__tmp6Line);
                StringBuilder __tmp7 = new StringBuilder();
                __tmp7.Append(GetParameters(op, false));
                using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
                {
                    bool __tmp7_first = true;
                    while(__tmp7_first || !__tmp7Reader.EndOfStream)
                    {
                        __tmp7_first = false;
                        string __tmp7Line = __tmp7Reader.ReadLine();
                        if (__tmp7Line == null)
                        {
                            __tmp7Line = "";
                        }
                        __out.Append(__tmp7Line);
                        __out.Append(__tmp2Suffix);
                        __out.AppendLine(); //516:98
                    }
                }
                string __tmp8Prefix = "    "; //517:1
                string __tmp9Suffix = ");"; //517:135
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(GetReturn(op));
                using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
                {
                    bool __tmp10_first = true;
                    while(__tmp10_first || !__tmp10Reader.EndOfStream)
                    {
                        __tmp10_first = false;
                        string __tmp10Line = __tmp10Reader.ReadLine();
                        if (__tmp10Line == null)
                        {
                            __tmp10Line = "";
                        }
                        __out.Append(__tmp8Prefix);
                        __out.Append(__tmp10Line);
                    }
                }
                StringBuilder __tmp11 = new StringBuilder();
                __tmp11.Append(model.JavaFullImplementationName());
                using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
                {
                    bool __tmp11_first = true;
                    while(__tmp11_first || !__tmp11Reader.EndOfStream)
                    {
                        __tmp11_first = false;
                        string __tmp11Line = __tmp11Reader.ReadLine();
                        if (__tmp11Line == null)
                        {
                            __tmp11Line = "";
                        }
                        __out.Append(__tmp11Line);
                    }
                }
                string __tmp12Line = "."; //517:56
                __out.Append(__tmp12Line);
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(op.Parent.JavaName());
                using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
                {
                    bool __tmp13_first = true;
                    while(__tmp13_first || !__tmp13Reader.EndOfStream)
                    {
                        __tmp13_first = false;
                        string __tmp13Line = __tmp13Reader.ReadLine();
                        if (__tmp13Line == null)
                        {
                            __tmp13Line = "";
                        }
                        __out.Append(__tmp13Line);
                    }
                }
                string __tmp14Line = "_"; //517:79
                __out.Append(__tmp14Line);
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(op.Name.ToCamelCase());
                using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                {
                    bool __tmp15_first = true;
                    while(__tmp15_first || !__tmp15Reader.EndOfStream)
                    {
                        __tmp15_first = false;
                        string __tmp15Line = __tmp15Reader.ReadLine();
                        if (__tmp15Line == null)
                        {
                            __tmp15Line = "";
                        }
                        __out.Append(__tmp15Line);
                    }
                }
                string __tmp16Line = "("; //517:103
                __out.Append(__tmp16Line);
                StringBuilder __tmp17 = new StringBuilder();
                __tmp17.Append(GetImplCallParameterNames(op));
                using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
                {
                    bool __tmp17_first = true;
                    while(__tmp17_first || !__tmp17Reader.EndOfStream)
                    {
                        __tmp17_first = false;
                        string __tmp17Line = __tmp17Reader.ReadLine();
                        if (__tmp17Line == null)
                        {
                            __tmp17Line = "";
                        }
                        __out.Append(__tmp17Line);
                        __out.Append(__tmp9Suffix);
                        __out.AppendLine(); //517:137
                    }
                }
                __out.Append("}"); //518:1
                __out.AppendLine(); //518:2
            }
            return __out.ToString();
        }

        public string GetSuperClasses(MetaClass cls) //522:1
        {
            string result = ""; //523:2
            var __loop29_results = 
                (from __loop29_var1 in __Enumerate((cls).GetEnumerator()) //524:10
                from sup in __Enumerate((__loop29_var1.SuperClasses).GetEnumerator()) //524:15
                select new { __loop29_var1 = __loop29_var1, sup = sup}
                ).ToList(); //524:5
            int __loop29_iteration = 0;
            string delim = ""; //524:33
            foreach (var __tmp1 in __loop29_results)
            {
                ++__loop29_iteration;
                if (__loop29_iteration >= 2) //524:52
                {
                    delim = ", "; //524:52
                }
                var __loop29_var1 = __tmp1.__loop29_var1;
                var sup = __tmp1.sup;
                result += delim + sup.JavaFullName(); //525:3
            }
            return result; //527:2
        }

        public string GetAllSuperClasses(MetaClass cls) //530:1
        {
            string result = ""; //531:2
            var __loop30_results = 
                (from __loop30_var1 in __Enumerate((cls).GetEnumerator()) //532:10
                from sup in __Enumerate((__loop30_var1.GetAllSuperClasses(false)).GetEnumerator()) //532:15
                select new { __loop30_var1 = __loop30_var1, sup = sup}
                ).ToList(); //532:5
            int __loop30_iteration = 0;
            string delim = ""; //532:46
            foreach (var __tmp1 in __loop30_results)
            {
                ++__loop30_iteration;
                if (__loop30_iteration >= 2) //532:65
                {
                    delim = ", "; //532:65
                }
                var __loop30_var1 = __tmp1.__loop30_var1;
                var sup = __tmp1.sup;
                result += delim + sup.JavaFullName(); //533:3
            }
            return result; //535:2
        }

        public string GenerateMetaModelDescriptor(MetaModel model) //538:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //539:1
            string __tmp2Suffix = ";"; //539:37
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(model.Namespace.JavaName());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //539:38
                }
            }
            __out.AppendLine(); //540:1
            string __tmp4Prefix = "public final class "; //541:1
            string __tmp5Suffix = " {"; //541:48
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(model.JavaDescriptorName());
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //541:50
                }
            }
            __out.Append("    static {"); //542:1
            __out.AppendLine(); //542:13
            var __loop31_results = 
                (from __loop31_var1 in __Enumerate((model).GetEnumerator()) //543:11
                from Namespace in __Enumerate((__loop31_var1.Namespace).GetEnumerator()) //543:18
                from Declarations in __Enumerate((Namespace.Declarations).GetEnumerator()) //543:29
                from cls in __Enumerate((Declarations).GetEnumerator()).OfType<MetaClass>() //543:43
                select new { __loop31_var1 = __loop31_var1, Namespace = Namespace, Declarations = Declarations, cls = cls}
                ).ToList(); //543:6
            int __loop31_iteration = 0;
            foreach (var __tmp7 in __loop31_results)
            {
                ++__loop31_iteration;
                var __loop31_var1 = __tmp7.__loop31_var1;
                var Namespace = __tmp7.Namespace;
                var Declarations = __tmp7.Declarations;
                var cls = __tmp7.cls;
                string __tmp8Prefix = "        "; //544:1
                string __tmp9Suffix = ".staticInit();"; //544:25
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(cls.JavaName());
                using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
                {
                    bool __tmp10_first = true;
                    while(__tmp10_first || !__tmp10Reader.EndOfStream)
                    {
                        __tmp10_first = false;
                        string __tmp10Line = __tmp10Reader.ReadLine();
                        if (__tmp10Line == null)
                        {
                            __tmp10Line = "";
                        }
                        __out.Append(__tmp8Prefix);
                        __out.Append(__tmp10Line);
                        __out.Append(__tmp9Suffix);
                        __out.AppendLine(); //544:39
                    }
                }
            }
            __out.Append("    }"); //546:1
            __out.AppendLine(); //546:6
            __out.AppendLine(); //547:1
            __out.Append("    static void staticInit() {}"); //548:1
            __out.AppendLine(); //548:32
            __out.AppendLine(); //549:1
            string __tmp11Prefix = "	public static final String Uri = \""; //550:1
            string __tmp12Suffix = "\";"; //550:47
            StringBuilder __tmp13 = new StringBuilder();
            __tmp13.Append(model.Uri);
            using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
            {
                bool __tmp13_first = true;
                while(__tmp13_first || !__tmp13Reader.EndOfStream)
                {
                    __tmp13_first = false;
                    string __tmp13Line = __tmp13Reader.ReadLine();
                    if (__tmp13Line == null)
                    {
                        __tmp13Line = "";
                    }
                    __out.Append(__tmp11Prefix);
                    __out.Append(__tmp13Line);
                    __out.Append(__tmp12Suffix);
                    __out.AppendLine(); //550:49
                }
            }
            __out.AppendLine(); //551:1
            var __loop32_results = 
                (from __loop32_var1 in __Enumerate((model).GetEnumerator()) //552:11
                from Namespace in __Enumerate((__loop32_var1.Namespace).GetEnumerator()) //552:18
                from Declarations in __Enumerate((Namespace.Declarations).GetEnumerator()) //552:29
                from cls in __Enumerate((Declarations).GetEnumerator()).OfType<MetaClass>() //552:43
                select new { __loop32_var1 = __loop32_var1, Namespace = Namespace, Declarations = Declarations, cls = cls}
                ).ToList(); //552:6
            int __loop32_iteration = 0;
            foreach (var __tmp14 in __loop32_results)
            {
                ++__loop32_iteration;
                var __loop32_var1 = __tmp14.__loop32_var1;
                var Namespace = __tmp14.Namespace;
                var Declarations = __tmp14.Declarations;
                var cls = __tmp14.cls;
                string __tmp15Prefix = "    "; //553:1
                string __tmp16Suffix = string.Empty; 
                StringBuilder __tmp17 = new StringBuilder();
                __tmp17.Append(GenerateMetaModelClass(cls));
                using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
                {
                    bool __tmp17_first = true;
                    while(__tmp17_first || !__tmp17Reader.EndOfStream)
                    {
                        __tmp17_first = false;
                        string __tmp17Line = __tmp17Reader.ReadLine();
                        if (__tmp17Line == null)
                        {
                            __tmp17Line = "";
                        }
                        __out.Append(__tmp15Prefix);
                        __out.Append(__tmp17Line);
                        __out.Append(__tmp16Suffix);
                        __out.AppendLine(); //553:34
                    }
                }
            }
            __out.Append("}"); //555:1
            __out.AppendLine(); //555:2
            __out.AppendLine(); //556:1
            return __out.ToString();
        }

        public string GenerateMetaModelClass(MetaClass cls) //560:1
        {
            StringBuilder __out = new StringBuilder();
            __out.AppendLine(); //561:1
            string __tmp1Prefix = "public static final class "; //562:1
            string __tmp2Suffix = " {"; //562:43
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(cls.JavaName());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //562:45
                }
            }
            __out.Append("    static void staticInit() {}"); //563:1
            __out.AppendLine(); //563:32
            __out.AppendLine(); //564:1
            __out.Append("    static {"); //565:1
            __out.AppendLine(); //565:13
            string __tmp4Prefix = "        "; //566:1
            string __tmp5Suffix = ".staticInit();"; //566:45
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(cls.Model.JavaFullDescriptorName());
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //566:59
                }
            }
            __out.Append("    }"); //567:1
            __out.AppendLine(); //567:6
            __out.AppendLine(); //568:1
            __out.Append("    public static metadslx.core.MetaClass getMetaClass() {"); //569:1
            __out.AppendLine(); //569:59
            string __tmp7Prefix = "        return "; //570:1
            string __tmp8Suffix = "; "; //570:44
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(cls.JavaFullInstanceName());
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                while(__tmp9_first || !__tmp9Reader.EndOfStream)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    if (__tmp9Line == null)
                    {
                        __tmp9Line = "";
                    }
                    __out.Append(__tmp7Prefix);
                    __out.Append(__tmp9Line);
                    __out.Append(__tmp8Suffix);
                    __out.AppendLine(); //570:46
                }
            }
            __out.Append("    }"); //571:1
            __out.AppendLine(); //571:6
            __out.AppendLine(); //572:1
            var __loop33_results = 
                (from __loop33_var1 in __Enumerate((cls).GetEnumerator()) //573:11
                from prop in __Enumerate((__loop33_var1.Properties).GetEnumerator()) //573:16
                select new { __loop33_var1 = __loop33_var1, prop = prop}
                ).ToList(); //573:6
            int __loop33_iteration = 0;
            foreach (var __tmp10 in __loop33_results)
            {
                ++__loop33_iteration;
                var __loop33_var1 = __tmp10.__loop33_var1;
                var prop = __tmp10.prop;
                string __tmp11Prefix = "    "; //574:1
                string __tmp12Suffix = string.Empty; 
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(GeneratePropertyDeclaration(cls.Model, cls, prop));
                using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
                {
                    bool __tmp13_first = true;
                    while(__tmp13_first || !__tmp13Reader.EndOfStream)
                    {
                        __tmp13_first = false;
                        string __tmp13Line = __tmp13Reader.ReadLine();
                        if (__tmp13Line == null)
                        {
                            __tmp13Line = "";
                        }
                        __out.Append(__tmp11Prefix);
                        __out.Append(__tmp13Line);
                        __out.Append(__tmp12Suffix);
                        __out.AppendLine(); //574:56
                    }
                }
            }
            __out.Append("}"); //576:1
            __out.AppendLine(); //576:2
            return __out.ToString();
        }

        public string GenerateModelConstant(MetaModel model, MetaConstant mconst) //580:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "public static final "; //581:1
            string __tmp2Suffix = ";"; //581:63
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(mconst.Type.JavaFullName());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                }
            }
            string __tmp4Line = " "; //581:49
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(mconst.Name);
            using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
            {
                bool __tmp5_first = true;
                while(__tmp5_first || !__tmp5Reader.EndOfStream)
                {
                    __tmp5_first = false;
                    string __tmp5Line = __tmp5Reader.ReadLine();
                    if (__tmp5Line == null)
                    {
                        __tmp5Line = "";
                    }
                    __out.Append(__tmp5Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //581:64
                }
            }
            return __out.ToString();
        }

        public string GenerateModelConstantImpl(MetaModel model, MetaConstant mconst, Dictionary<ModelObject,string> mobjToTmp) //584:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = string.Empty; 
            string __tmp2Suffix = ";"; //585:51
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(mconst.Name);
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                }
            }
            string __tmp4Line = " = "; //585:14
            __out.Append(__tmp4Line);
            StringBuilder __tmp5 = new StringBuilder();
            __tmp5.Append(GenerateExpression(mconst.Value));
            using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
            {
                bool __tmp5_first = true;
                while(__tmp5_first || !__tmp5Reader.EndOfStream)
                {
                    __tmp5_first = false;
                    string __tmp5Line = __tmp5Reader.ReadLine();
                    if (__tmp5Line == null)
                    {
                        __tmp5Line = "";
                    }
                    __out.Append(__tmp5Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //585:52
                }
            }
            return __out.ToString();
        }

        public string GenerateMetaModelInstance(MetaModel model) //589:1
        {
            StringBuilder __out = new StringBuilder();
            Dictionary<ModelObject,string> mobjToName = model.GetNamedModelObjects(); //590:2
            string __tmp1Prefix = string.Empty;
            string __tmp2Suffix = string.Empty;
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(ResetCounters());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                }
            }
            string __tmp4Prefix = "package "; //592:1
            string __tmp5Suffix = ";"; //592:37
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(model.Namespace.JavaName());
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //592:38
                }
            }
            __out.AppendLine(); //593:1
            string __tmp7Prefix = "public final class "; //594:1
            string __tmp8Suffix = string.Empty; 
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(model.CSharpInstancesName());
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                while(__tmp9_first || !__tmp9Reader.EndOfStream)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    if (__tmp9Line == null)
                    {
                        __tmp9Line = "";
                    }
                    __out.Append(__tmp7Prefix);
                    __out.Append(__tmp9Line);
                    __out.Append(__tmp8Suffix);
                    __out.AppendLine(); //594:49
                }
            }
            __out.Append("{"); //595:1
            __out.AppendLine(); //595:2
            __out.Append("    private static metadslx.core.Model model;"); //596:1
            __out.AppendLine(); //596:46
            __out.AppendLine(); //597:1
            __out.Append("    public static metadslx.core.Model model() {"); //598:1
            __out.AppendLine(); //598:48
            string __tmp10Prefix = "        return "; //599:1
            string __tmp11Suffix = "Instance.model;"; //599:28
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(model.Name);
            using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
            {
                bool __tmp12_first = true;
                while(__tmp12_first || !__tmp12Reader.EndOfStream)
                {
                    __tmp12_first = false;
                    string __tmp12Line = __tmp12Reader.ReadLine();
                    if (__tmp12Line == null)
                    {
                        __tmp12Line = "";
                    }
                    __out.Append(__tmp10Prefix);
                    __out.Append(__tmp12Line);
                    __out.Append(__tmp11Suffix);
                    __out.AppendLine(); //599:43
                }
            }
            __out.Append("    }"); //600:1
            __out.AppendLine(); //600:6
            __out.AppendLine(); //601:1
            __out.Append("    public static final metadslx.core.MetaModel Meta;"); //602:1
            __out.AppendLine(); //602:54
            __out.AppendLine(); //603:1
            var __loop34_results = 
                (from __loop34_var1 in __Enumerate((model).GetEnumerator()) //604:11
                from Namespace in __Enumerate((__loop34_var1.Namespace).GetEnumerator()) //604:18
                from Declarations in __Enumerate((Namespace.Declarations).GetEnumerator()) //604:29
                from c in __Enumerate((Declarations).GetEnumerator()).OfType<MetaConstant>() //604:43
                select new { __loop34_var1 = __loop34_var1, Namespace = Namespace, Declarations = Declarations, c = c}
                ).ToList(); //604:6
            int __loop34_iteration = 0;
            foreach (var __tmp13 in __loop34_results)
            {
                ++__loop34_iteration;
                var __loop34_var1 = __tmp13.__loop34_var1;
                var Namespace = __tmp13.Namespace;
                var Declarations = __tmp13.Declarations;
                var c = __tmp13.c;
                string __tmp14Prefix = "    "; //605:1
                string __tmp15Suffix = string.Empty; 
                StringBuilder __tmp16 = new StringBuilder();
                __tmp16.Append(GenerateModelConstant(model, c));
                using(StreamReader __tmp16Reader = new StreamReader(this.__ToStream(__tmp16.ToString())))
                {
                    bool __tmp16_first = true;
                    while(__tmp16_first || !__tmp16Reader.EndOfStream)
                    {
                        __tmp16_first = false;
                        string __tmp16Line = __tmp16Reader.ReadLine();
                        if (__tmp16Line == null)
                        {
                            __tmp16Line = "";
                        }
                        __out.Append(__tmp14Prefix);
                        __out.Append(__tmp16Line);
                        __out.Append(__tmp15Suffix);
                        __out.AppendLine(); //605:38
                    }
                }
            }
            __out.AppendLine(); //607:1
            var __loop35_results = 
                (from mobj in __Enumerate((Instances).GetEnumerator()) //608:11
                select new { mobj = mobj}
                ).ToList(); //608:6
            int __loop35_iteration = 0;
            foreach (var __tmp17 in __loop35_results)
            {
                ++__loop35_iteration;
                var mobj = __tmp17.mobj;
                string __tmp18Prefix = "	"; //609:1
                string __tmp19Suffix = string.Empty; 
                StringBuilder __tmp20 = new StringBuilder();
                __tmp20.Append(GenerateModelObjectInstanceDeclaration(mobj, mobjToName));
                using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
                {
                    bool __tmp20_first = true;
                    while(__tmp20_first || !__tmp20Reader.EndOfStream)
                    {
                        __tmp20_first = false;
                        string __tmp20Line = __tmp20Reader.ReadLine();
                        if (__tmp20Line == null)
                        {
                            __tmp20Line = "";
                        }
                        __out.Append(__tmp18Prefix);
                        __out.Append(__tmp20Line);
                        __out.Append(__tmp19Suffix);
                        __out.AppendLine(); //609:60
                    }
                }
            }
            __out.AppendLine(); //611:1
            __out.Append("    static {"); //612:1
            __out.AppendLine(); //612:13
            string __tmp21Prefix = "		"; //613:1
            string __tmp22Suffix = ".staticInit();"; //613:31
            StringBuilder __tmp23 = new StringBuilder();
            __tmp23.Append(model.JavaDescriptorName());
            using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
            {
                bool __tmp23_first = true;
                while(__tmp23_first || !__tmp23Reader.EndOfStream)
                {
                    __tmp23_first = false;
                    string __tmp23Line = __tmp23Reader.ReadLine();
                    if (__tmp23Line == null)
                    {
                        __tmp23Line = "";
                    }
                    __out.Append(__tmp21Prefix);
                    __out.Append(__tmp23Line);
                    __out.Append(__tmp22Suffix);
                    __out.AppendLine(); //613:45
                }
            }
            string __tmp24Prefix = "		"; //614:1
            string __tmp25Suffix = ".model = new metadslx.core.Model();"; //614:30
            StringBuilder __tmp26 = new StringBuilder();
            __tmp26.Append(model.JavaInstancesName());
            using(StreamReader __tmp26Reader = new StreamReader(this.__ToStream(__tmp26.ToString())))
            {
                bool __tmp26_first = true;
                while(__tmp26_first || !__tmp26Reader.EndOfStream)
                {
                    __tmp26_first = false;
                    string __tmp26Line = __tmp26Reader.ReadLine();
                    if (__tmp26Line == null)
                    {
                        __tmp26Line = "";
                    }
                    __out.Append(__tmp24Prefix);
                    __out.Append(__tmp26Line);
                    __out.Append(__tmp25Suffix);
                    __out.AppendLine(); //614:65
                }
            }
            string __tmp27Prefix = "   		try (metadslx.core.ModelContextScope _scope = new metadslx.core.ModelContextScope("; //615:1
            string __tmp28Suffix = ".model)) {"; //615:115
            StringBuilder __tmp29 = new StringBuilder();
            __tmp29.Append(model.JavaInstancesName());
            using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
            {
                bool __tmp29_first = true;
                while(__tmp29_first || !__tmp29Reader.EndOfStream)
                {
                    __tmp29_first = false;
                    string __tmp29Line = __tmp29Reader.ReadLine();
                    if (__tmp29Line == null)
                    {
                        __tmp29Line = "";
                    }
                    __out.Append(__tmp27Prefix);
                    __out.Append(__tmp29Line);
                    __out.Append(__tmp28Suffix);
                    __out.AppendLine(); //615:125
                }
            }
            var __loop36_results = 
                (from __loop36_var1 in __Enumerate((model).GetEnumerator()) //616:13
                from Namespace in __Enumerate((__loop36_var1.Namespace).GetEnumerator()) //616:20
                from Declarations in __Enumerate((Namespace.Declarations).GetEnumerator()) //616:31
                from c in __Enumerate((Declarations).GetEnumerator()).OfType<MetaConstant>() //616:45
                select new { __loop36_var1 = __loop36_var1, Namespace = Namespace, Declarations = Declarations, c = c}
                ).ToList(); //616:8
            int __loop36_iteration = 0;
            foreach (var __tmp30 in __loop36_results)
            {
                ++__loop36_iteration;
                var __loop36_var1 = __tmp30.__loop36_var1;
                var Namespace = __tmp30.Namespace;
                var Declarations = __tmp30.Declarations;
                var c = __tmp30.c;
                string __tmp31Prefix = "            "; //617:1
                string __tmp32Suffix = string.Empty; 
                StringBuilder __tmp33 = new StringBuilder();
                __tmp33.Append(GenerateModelConstantImpl(model, c, mobjToName));
                using(StreamReader __tmp33Reader = new StreamReader(this.__ToStream(__tmp33.ToString())))
                {
                    bool __tmp33_first = true;
                    while(__tmp33_first || !__tmp33Reader.EndOfStream)
                    {
                        __tmp33_first = false;
                        string __tmp33Line = __tmp33Reader.ReadLine();
                        if (__tmp33Line == null)
                        {
                            __tmp33Line = "";
                        }
                        __out.Append(__tmp31Prefix);
                        __out.Append(__tmp33Line);
                        __out.Append(__tmp32Suffix);
                        __out.AppendLine(); //617:62
                    }
                }
            }
            __out.AppendLine(); //619:1
            var __loop37_results = 
                (from mobj in __Enumerate((Instances).GetEnumerator()) //620:10
                select new { mobj = mobj}
                ).ToList(); //620:5
            int __loop37_iteration = 0;
            foreach (var __tmp34 in __loop37_results)
            {
                ++__loop37_iteration;
                var mobj = __tmp34.mobj;
                string __tmp35Prefix = "			"; //621:1
                string __tmp36Suffix = string.Empty; 
                StringBuilder __tmp37 = new StringBuilder();
                __tmp37.Append(GenerateModelObjectInstance(mobj, mobjToName));
                using(StreamReader __tmp37Reader = new StreamReader(this.__ToStream(__tmp37.ToString())))
                {
                    bool __tmp37_first = true;
                    while(__tmp37_first || !__tmp37Reader.EndOfStream)
                    {
                        __tmp37_first = false;
                        string __tmp37Line = __tmp37Reader.ReadLine();
                        if (__tmp37Line == null)
                        {
                            __tmp37Line = "";
                        }
                        __out.Append(__tmp35Prefix);
                        __out.Append(__tmp37Line);
                        __out.Append(__tmp36Suffix);
                        __out.AppendLine(); //621:51
                    }
                }
            }
            __out.AppendLine(); //623:1
            __out.Append("			init();"); //624:1
            __out.AppendLine(); //624:11
            __out.AppendLine(); //625:1
            string __tmp38Prefix = "            "; //626:1
            string __tmp39Suffix = ".model.evalLazyValues();"; //626:40
            StringBuilder __tmp40 = new StringBuilder();
            __tmp40.Append(model.JavaInstancesName());
            using(StreamReader __tmp40Reader = new StreamReader(this.__ToStream(__tmp40.ToString())))
            {
                bool __tmp40_first = true;
                while(__tmp40_first || !__tmp40Reader.EndOfStream)
                {
                    __tmp40_first = false;
                    string __tmp40Line = __tmp40Reader.ReadLine();
                    if (__tmp40Line == null)
                    {
                        __tmp40Line = "";
                    }
                    __out.Append(__tmp38Prefix);
                    __out.Append(__tmp40Line);
                    __out.Append(__tmp39Suffix);
                    __out.AppendLine(); //626:64
                }
            }
            __out.Append("		}"); //627:1
            __out.AppendLine(); //627:4
            __out.Append("    }"); //628:1
            __out.AppendLine(); //628:6
            __out.AppendLine(); //629:1
            __out.Append("	private static void init0() {"); //630:1
            __out.AppendLine(); //630:31
            var __loop38_results = 
                (from mobj in __Enumerate((Instances).GetEnumerator()) //631:8
                select new { mobj = mobj}
                ).ToList(); //631:3
            int __loop38_iteration = 0;
            foreach (var __tmp41 in __loop38_results)
            {
                ++__loop38_iteration;
                var mobj = __tmp41.mobj;
                string __tmp42Prefix = "	"; //632:1
                string __tmp43Suffix = string.Empty; 
                StringBuilder __tmp44 = new StringBuilder();
                __tmp44.Append(GenerateModelObjectInstanceInitializer(mobj, mobjToName));
                using(StreamReader __tmp44Reader = new StreamReader(this.__ToStream(__tmp44.ToString())))
                {
                    bool __tmp44_first = true;
                    while(__tmp44_first || !__tmp44Reader.EndOfStream)
                    {
                        __tmp44_first = false;
                        string __tmp44Line = __tmp44Reader.ReadLine();
                        if (__tmp44Line == null)
                        {
                            __tmp44Line = "";
                        }
                        __out.Append(__tmp42Prefix);
                        __out.Append(__tmp44Line);
                        __out.Append(__tmp43Suffix);
                        __out.AppendLine(); //632:60
                    }
                }
            }
            __out.Append("	}"); //634:1
            __out.AppendLine(); //634:3
            __out.AppendLine(); //635:1
            __out.Append("	private static void init() {"); //636:1
            __out.AppendLine(); //636:30
            var __loop39_results = 
                (from i in __Enumerate((Enumerable.Range(0, Properties.FunctionCount)).GetEnumerator()) //637:8
                select new { i = i}
                ).ToList(); //637:3
            int __loop39_iteration = 0;
            foreach (var __tmp45 in __loop39_results)
            {
                ++__loop39_iteration;
                var i = __tmp45.i;
                string __tmp46Prefix = "		init"; //638:1
                string __tmp47Suffix = "();"; //638:10
                StringBuilder __tmp48 = new StringBuilder();
                __tmp48.Append(i);
                using(StreamReader __tmp48Reader = new StreamReader(this.__ToStream(__tmp48.ToString())))
                {
                    bool __tmp48_first = true;
                    while(__tmp48_first || !__tmp48Reader.EndOfStream)
                    {
                        __tmp48_first = false;
                        string __tmp48Line = __tmp48Reader.ReadLine();
                        if (__tmp48Line == null)
                        {
                            __tmp48Line = "";
                        }
                        __out.Append(__tmp46Prefix);
                        __out.Append(__tmp48Line);
                        __out.Append(__tmp47Suffix);
                        __out.AppendLine(); //638:13
                    }
                }
            }
            __out.Append("	}"); //640:1
            __out.AppendLine(); //640:3
            __out.Append("}"); //641:1
            __out.AppendLine(); //641:2
            return __out.ToString();
        }

        public string GenerateModelObjectInstanceDeclaration(ModelObject mobj, Dictionary<ModelObject,string> mobjToName) //645:1
        {
            StringBuilder __out = new StringBuilder();
            if (mobj != null && mobj.MMetaClass != null) //646:2
            {
                if (mobjToName.ContainsKey(mobj)) //647:3
                {
                    string name = mobjToName[mobj]; //648:4
                    if (name.StartsWith("__")) //649:4
                    {
                        string __tmp1Prefix = "private static final metadslx.core."; //650:1
                        string __tmp2Suffix = ";"; //650:71
                        StringBuilder __tmp3 = new StringBuilder();
                        __tmp3.Append(mobj.MMetaClass.JavaName());
                        using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                        {
                            bool __tmp3_first = true;
                            while(__tmp3_first || !__tmp3Reader.EndOfStream)
                            {
                                __tmp3_first = false;
                                string __tmp3Line = __tmp3Reader.ReadLine();
                                if (__tmp3Line == null)
                                {
                                    __tmp3Line = "";
                                }
                                __out.Append(__tmp1Prefix);
                                __out.Append(__tmp3Line);
                            }
                        }
                        string __tmp4Line = " "; //650:64
                        __out.Append(__tmp4Line);
                        StringBuilder __tmp5 = new StringBuilder();
                        __tmp5.Append(name);
                        using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                        {
                            bool __tmp5_first = true;
                            while(__tmp5_first || !__tmp5Reader.EndOfStream)
                            {
                                __tmp5_first = false;
                                string __tmp5Line = __tmp5Reader.ReadLine();
                                if (__tmp5Line == null)
                                {
                                    __tmp5Line = "";
                                }
                                __out.Append(__tmp5Line);
                                __out.Append(__tmp2Suffix);
                                __out.AppendLine(); //650:72
                            }
                        }
                    }
                    else //651:4
                    {
                        string __tmp6Prefix = "public static final metadslx.core."; //652:1
                        string __tmp7Suffix = ";"; //652:70
                        StringBuilder __tmp8 = new StringBuilder();
                        __tmp8.Append(mobj.MMetaClass.JavaName());
                        using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
                        {
                            bool __tmp8_first = true;
                            while(__tmp8_first || !__tmp8Reader.EndOfStream)
                            {
                                __tmp8_first = false;
                                string __tmp8Line = __tmp8Reader.ReadLine();
                                if (__tmp8Line == null)
                                {
                                    __tmp8Line = "";
                                }
                                __out.Append(__tmp6Prefix);
                                __out.Append(__tmp8Line);
                            }
                        }
                        string __tmp9Line = " "; //652:63
                        __out.Append(__tmp9Line);
                        StringBuilder __tmp10 = new StringBuilder();
                        __tmp10.Append(name);
                        using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
                        {
                            bool __tmp10_first = true;
                            while(__tmp10_first || !__tmp10Reader.EndOfStream)
                            {
                                __tmp10_first = false;
                                string __tmp10Line = __tmp10Reader.ReadLine();
                                if (__tmp10Line == null)
                                {
                                    __tmp10Line = "";
                                }
                                __out.Append(__tmp10Line);
                                __out.Append(__tmp7Suffix);
                                __out.AppendLine(); //652:71
                            }
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateModelObjectInstance(ModelObject mobj, Dictionary<ModelObject,string> mobjToName) //659:1
        {
            StringBuilder __out = new StringBuilder();
            if (mobj != null && mobj.MMetaClass != null) //660:2
            {
                if (mobjToName.ContainsKey(mobj)) //661:3
                {
                    string name = mobjToName[mobj]; //662:4
                    string __tmp1Prefix = string.Empty; 
                    string __tmp2Suffix = "();"; //663:83
                    StringBuilder __tmp3 = new StringBuilder();
                    __tmp3.Append(name);
                    using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                    {
                        bool __tmp3_first = true;
                        while(__tmp3_first || !__tmp3Reader.EndOfStream)
                        {
                            __tmp3_first = false;
                            string __tmp3Line = __tmp3Reader.ReadLine();
                            if (__tmp3Line == null)
                            {
                                __tmp3Line = "";
                            }
                            __out.Append(__tmp1Prefix);
                            __out.Append(__tmp3Line);
                        }
                    }
                    string __tmp4Line = " = metadslx.core.MetaFactory.instance().create"; //663:7
                    __out.Append(__tmp4Line);
                    StringBuilder __tmp5 = new StringBuilder();
                    __tmp5.Append(mobj.MMetaClass.CSharpName());
                    using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                    {
                        bool __tmp5_first = true;
                        while(__tmp5_first || !__tmp5Reader.EndOfStream)
                        {
                            __tmp5_first = false;
                            string __tmp5Line = __tmp5Reader.ReadLine();
                            if (__tmp5Line == null)
                            {
                                __tmp5Line = "";
                            }
                            __out.Append(__tmp5Line);
                            __out.Append(__tmp2Suffix);
                            __out.AppendLine(); //663:86
                        }
                    }
                    if (mobj is MetaModel) //664:4
                    {
                        string __tmp6Prefix = "Meta = "; //665:1
                        string __tmp7Suffix = ";"; //665:14
                        StringBuilder __tmp8 = new StringBuilder();
                        __tmp8.Append(name);
                        using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
                        {
                            bool __tmp8_first = true;
                            while(__tmp8_first || !__tmp8Reader.EndOfStream)
                            {
                                __tmp8_first = false;
                                string __tmp8Line = __tmp8Reader.ReadLine();
                                if (__tmp8Line == null)
                                {
                                    __tmp8Line = "";
                                }
                                __out.Append(__tmp6Prefix);
                                __out.Append(__tmp8Line);
                                __out.Append(__tmp7Suffix);
                                __out.AppendLine(); //665:15
                            }
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateModelObjectInstanceInitializer(ModelObject mobj, Dictionary<ModelObject,string> mobjToName) //672:1
        {
            StringBuilder __out = new StringBuilder();
            if (mobj != null && mobj.MMetaClass != null) //673:2
            {
                if (mobjToName.ContainsKey(mobj)) //674:3
                {
                    var __loop40_results = 
                        (from __loop40_var1 in __Enumerate((mobj).GetEnumerator()) //675:9
                        from prop in __Enumerate((__loop40_var1.MGetAllProperties()).GetEnumerator()) //675:15
                        select new { __loop40_var1 = __loop40_var1, prop = prop}
                        ).ToList(); //675:4
                    int __loop40_iteration = 0;
                    foreach (var __tmp1 in __loop40_results)
                    {
                        ++__loop40_iteration;
                        var __loop40_var1 = __tmp1.__loop40_var1;
                        var prop = __tmp1.prop;
                        if (prop.MetaProperty != null && prop.MetaProperty.Kind != MetaPropertyKind.Derived) //676:5
                        {
                            object propValue = mobj.MGet(prop); //677:6
                            if ((++Properties.LineCount) % 1000 == 0) //678:6
                            {
                                __out.Append("}"); //679:1
                                __out.AppendLine(); //679:2
                                string __tmp2Prefix = "private static void init"; //680:1
                                string __tmp3Suffix = "() {"; //680:53
                                StringBuilder __tmp4 = new StringBuilder();
                                __tmp4.Append(++Properties.FunctionCount);
                                using(StreamReader __tmp4Reader = new StreamReader(this.__ToStream(__tmp4.ToString())))
                                {
                                    bool __tmp4_first = true;
                                    while(__tmp4_first || !__tmp4Reader.EndOfStream)
                                    {
                                        __tmp4_first = false;
                                        string __tmp4Line = __tmp4Reader.ReadLine();
                                        if (__tmp4Line == null)
                                        {
                                            __tmp4Line = "";
                                        }
                                        __out.Append(__tmp2Prefix);
                                        __out.Append(__tmp4Line);
                                        __out.Append(__tmp3Suffix);
                                        __out.AppendLine(); //680:57
                                    }
                                }
                            }
                            string __tmp5Prefix = "	"; //682:1
                            string __tmp6Suffix = string.Empty; 
                            StringBuilder __tmp7 = new StringBuilder();
                            __tmp7.Append(GenerateModelObjectPropertyValue(mobj, prop, propValue, mobjToName));
                            using(StreamReader __tmp7Reader = new StreamReader(this.__ToStream(__tmp7.ToString())))
                            {
                                bool __tmp7_first = true;
                                while(__tmp7_first || !__tmp7Reader.EndOfStream)
                                {
                                    __tmp7_first = false;
                                    string __tmp7Line = __tmp7Reader.ReadLine();
                                    if (__tmp7Line == null)
                                    {
                                        __tmp7Line = "";
                                    }
                                    __out.Append(__tmp5Prefix);
                                    __out.Append(__tmp7Line);
                                    __out.Append(__tmp6Suffix);
                                    __out.AppendLine(); //682:71
                                }
                            }
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateModelObjectPropertyValue(ModelObject mobj, ModelProperty prop, object value, Dictionary<ModelObject,string> mobjToName) //690:1
        {
            StringBuilder __out = new StringBuilder();
            string name = mobjToName[mobj]; //691:2
            string propDeclName = prop.JavaFullDeclaredName(); //692:2
            if (!prop.IsCollection) //693:2
            {
                string __tmp1Prefix = "((metadslx.core.ModelObject)"; //694:1
                string __tmp2Suffix = ");"; //694:58
                StringBuilder __tmp3 = new StringBuilder();
                __tmp3.Append(name);
                using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
                {
                    bool __tmp3_first = true;
                    while(__tmp3_first || !__tmp3Reader.EndOfStream)
                    {
                        __tmp3_first = false;
                        string __tmp3Line = __tmp3Reader.ReadLine();
                        if (__tmp3Line == null)
                        {
                            __tmp3Line = "";
                        }
                        __out.Append(__tmp1Prefix);
                        __out.Append(__tmp3Line);
                    }
                }
                string __tmp4Line = ").mUnSet("; //694:35
                __out.Append(__tmp4Line);
                StringBuilder __tmp5 = new StringBuilder();
                __tmp5.Append(propDeclName);
                using(StreamReader __tmp5Reader = new StreamReader(this.__ToStream(__tmp5.ToString())))
                {
                    bool __tmp5_first = true;
                    while(__tmp5_first || !__tmp5Reader.EndOfStream)
                    {
                        __tmp5_first = false;
                        string __tmp5Line = __tmp5Reader.ReadLine();
                        if (__tmp5Line == null)
                        {
                            __tmp5Line = "";
                        }
                        __out.Append(__tmp5Line);
                        __out.Append(__tmp2Suffix);
                        __out.AppendLine(); //694:60
                    }
                }
            }
            ModelObject moValue = value as ModelObject; //696:2
            if (value == null) //697:2
            {
                string __tmp6Prefix = "((metadslx.core.ModelObject)"; //698:1
                string __tmp7Suffix = ", metadslx.core.Lazy.create(() -> null, true));"; //698:60
                StringBuilder __tmp8 = new StringBuilder();
                __tmp8.Append(name);
                using(StreamReader __tmp8Reader = new StreamReader(this.__ToStream(__tmp8.ToString())))
                {
                    bool __tmp8_first = true;
                    while(__tmp8_first || !__tmp8Reader.EndOfStream)
                    {
                        __tmp8_first = false;
                        string __tmp8Line = __tmp8Reader.ReadLine();
                        if (__tmp8Line == null)
                        {
                            __tmp8Line = "";
                        }
                        __out.Append(__tmp6Prefix);
                        __out.Append(__tmp8Line);
                    }
                }
                string __tmp9Line = ").mLazyAdd("; //698:35
                __out.Append(__tmp9Line);
                StringBuilder __tmp10 = new StringBuilder();
                __tmp10.Append(propDeclName);
                using(StreamReader __tmp10Reader = new StreamReader(this.__ToStream(__tmp10.ToString())))
                {
                    bool __tmp10_first = true;
                    while(__tmp10_first || !__tmp10Reader.EndOfStream)
                    {
                        __tmp10_first = false;
                        string __tmp10Line = __tmp10Reader.ReadLine();
                        if (__tmp10Line == null)
                        {
                            __tmp10Line = "";
                        }
                        __out.Append(__tmp10Line);
                        __out.Append(__tmp7Suffix);
                        __out.AppendLine(); //698:107
                    }
                }
            }
            else if (value is string) //699:2
            {
                string __tmp11Prefix = "((metadslx.core.ModelObject)"; //700:1
                string __tmp12Suffix = "\", true));"; //700:102
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(name);
                using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
                {
                    bool __tmp13_first = true;
                    while(__tmp13_first || !__tmp13Reader.EndOfStream)
                    {
                        __tmp13_first = false;
                        string __tmp13Line = __tmp13Reader.ReadLine();
                        if (__tmp13Line == null)
                        {
                            __tmp13Line = "";
                        }
                        __out.Append(__tmp11Prefix);
                        __out.Append(__tmp13Line);
                    }
                }
                string __tmp14Line = ").mLazyAdd("; //700:35
                __out.Append(__tmp14Line);
                StringBuilder __tmp15 = new StringBuilder();
                __tmp15.Append(propDeclName);
                using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
                {
                    bool __tmp15_first = true;
                    while(__tmp15_first || !__tmp15Reader.EndOfStream)
                    {
                        __tmp15_first = false;
                        string __tmp15Line = __tmp15Reader.ReadLine();
                        if (__tmp15Line == null)
                        {
                            __tmp15Line = "";
                        }
                        __out.Append(__tmp15Line);
                    }
                }
                string __tmp16Line = ", metadslx.core.Lazy.create(() -> \""; //700:60
                __out.Append(__tmp16Line);
                StringBuilder __tmp17 = new StringBuilder();
                __tmp17.Append(value);
                using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
                {
                    bool __tmp17_first = true;
                    while(__tmp17_first || !__tmp17Reader.EndOfStream)
                    {
                        __tmp17_first = false;
                        string __tmp17Line = __tmp17Reader.ReadLine();
                        if (__tmp17Line == null)
                        {
                            __tmp17Line = "";
                        }
                        __out.Append(__tmp17Line);
                        __out.Append(__tmp12Suffix);
                        __out.AppendLine(); //700:112
                    }
                }
            }
            else if (value is bool) //701:2
            {
                string __tmp18Prefix = "((metadslx.core.ModelObject)"; //702:1
                string __tmp19Suffix = ", true));"; //702:122
                StringBuilder __tmp20 = new StringBuilder();
                __tmp20.Append(name);
                using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
                {
                    bool __tmp20_first = true;
                    while(__tmp20_first || !__tmp20Reader.EndOfStream)
                    {
                        __tmp20_first = false;
                        string __tmp20Line = __tmp20Reader.ReadLine();
                        if (__tmp20Line == null)
                        {
                            __tmp20Line = "";
                        }
                        __out.Append(__tmp18Prefix);
                        __out.Append(__tmp20Line);
                    }
                }
                string __tmp21Line = ").mLazyAdd("; //702:35
                __out.Append(__tmp21Line);
                StringBuilder __tmp22 = new StringBuilder();
                __tmp22.Append(propDeclName);
                using(StreamReader __tmp22Reader = new StreamReader(this.__ToStream(__tmp22.ToString())))
                {
                    bool __tmp22_first = true;
                    while(__tmp22_first || !__tmp22Reader.EndOfStream)
                    {
                        __tmp22_first = false;
                        string __tmp22Line = __tmp22Reader.ReadLine();
                        if (__tmp22Line == null)
                        {
                            __tmp22Line = "";
                        }
                        __out.Append(__tmp22Line);
                    }
                }
                string __tmp23Line = ", metadslx.core.Lazy.create(() -> "; //702:60
                __out.Append(__tmp23Line);
                StringBuilder __tmp24 = new StringBuilder();
                __tmp24.Append(value.ToString().ToLower());
                using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                {
                    bool __tmp24_first = true;
                    while(__tmp24_first || !__tmp24Reader.EndOfStream)
                    {
                        __tmp24_first = false;
                        string __tmp24Line = __tmp24Reader.ReadLine();
                        if (__tmp24Line == null)
                        {
                            __tmp24Line = "";
                        }
                        __out.Append(__tmp24Line);
                        __out.Append(__tmp19Suffix);
                        __out.AppendLine(); //702:131
                    }
                }
            }
            else if (value.GetType().IsPrimitive) //703:2
            {
                string __tmp25Prefix = "((metadslx.core.ModelObject)"; //704:1
                string __tmp26Suffix = ", true));"; //704:112
                StringBuilder __tmp27 = new StringBuilder();
                __tmp27.Append(name);
                using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
                {
                    bool __tmp27_first = true;
                    while(__tmp27_first || !__tmp27Reader.EndOfStream)
                    {
                        __tmp27_first = false;
                        string __tmp27Line = __tmp27Reader.ReadLine();
                        if (__tmp27Line == null)
                        {
                            __tmp27Line = "";
                        }
                        __out.Append(__tmp25Prefix);
                        __out.Append(__tmp27Line);
                    }
                }
                string __tmp28Line = ").mLazyAdd("; //704:35
                __out.Append(__tmp28Line);
                StringBuilder __tmp29 = new StringBuilder();
                __tmp29.Append(propDeclName);
                using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
                {
                    bool __tmp29_first = true;
                    while(__tmp29_first || !__tmp29Reader.EndOfStream)
                    {
                        __tmp29_first = false;
                        string __tmp29Line = __tmp29Reader.ReadLine();
                        if (__tmp29Line == null)
                        {
                            __tmp29Line = "";
                        }
                        __out.Append(__tmp29Line);
                    }
                }
                string __tmp30Line = ", metadslx.core.Lazy.create(() -> "; //704:60
                __out.Append(__tmp30Line);
                StringBuilder __tmp31 = new StringBuilder();
                __tmp31.Append(value.ToString());
                using(StreamReader __tmp31Reader = new StreamReader(this.__ToStream(__tmp31.ToString())))
                {
                    bool __tmp31_first = true;
                    while(__tmp31_first || !__tmp31Reader.EndOfStream)
                    {
                        __tmp31_first = false;
                        string __tmp31Line = __tmp31Reader.ReadLine();
                        if (__tmp31Line == null)
                        {
                            __tmp31Line = "";
                        }
                        __out.Append(__tmp31Line);
                        __out.Append(__tmp26Suffix);
                        __out.AppendLine(); //704:121
                    }
                }
            }
            else if (MetaBuiltInTypes.Types.Contains(value)) //705:2
            {
                string __tmp32Prefix = "((metadslx.core.ModelObject)"; //706:1
                string __tmp33Suffix = ", true));"; //706:117
                StringBuilder __tmp34 = new StringBuilder();
                __tmp34.Append(name);
                using(StreamReader __tmp34Reader = new StreamReader(this.__ToStream(__tmp34.ToString())))
                {
                    bool __tmp34_first = true;
                    while(__tmp34_first || !__tmp34Reader.EndOfStream)
                    {
                        __tmp34_first = false;
                        string __tmp34Line = __tmp34Reader.ReadLine();
                        if (__tmp34Line == null)
                        {
                            __tmp34Line = "";
                        }
                        __out.Append(__tmp32Prefix);
                        __out.Append(__tmp34Line);
                    }
                }
                string __tmp35Line = ").mLazyAdd("; //706:35
                __out.Append(__tmp35Line);
                StringBuilder __tmp36 = new StringBuilder();
                __tmp36.Append(propDeclName);
                using(StreamReader __tmp36Reader = new StreamReader(this.__ToStream(__tmp36.ToString())))
                {
                    bool __tmp36_first = true;
                    while(__tmp36_first || !__tmp36Reader.EndOfStream)
                    {
                        __tmp36_first = false;
                        string __tmp36Line = __tmp36Reader.ReadLine();
                        if (__tmp36Line == null)
                        {
                            __tmp36Line = "";
                        }
                        __out.Append(__tmp36Line);
                    }
                }
                string __tmp37Line = ", metadslx.core.Lazy.create(() -> "; //706:60
                __out.Append(__tmp37Line);
                StringBuilder __tmp38 = new StringBuilder();
                __tmp38.Append(GenerateTypeOf(value));
                using(StreamReader __tmp38Reader = new StreamReader(this.__ToStream(__tmp38.ToString())))
                {
                    bool __tmp38_first = true;
                    while(__tmp38_first || !__tmp38Reader.EndOfStream)
                    {
                        __tmp38_first = false;
                        string __tmp38Line = __tmp38Reader.ReadLine();
                        if (__tmp38Line == null)
                        {
                            __tmp38Line = "";
                        }
                        __out.Append(__tmp38Line);
                        __out.Append(__tmp33Suffix);
                        __out.AppendLine(); //706:126
                    }
                }
            }
            else if (value is MetaPrimitiveType) //707:2
            {
                string __tmp39Prefix = "((metadslx.core.ModelObject)"; //708:1
                string __tmp40Suffix = ", true));"; //708:117
                StringBuilder __tmp41 = new StringBuilder();
                __tmp41.Append(name);
                using(StreamReader __tmp41Reader = new StreamReader(this.__ToStream(__tmp41.ToString())))
                {
                    bool __tmp41_first = true;
                    while(__tmp41_first || !__tmp41Reader.EndOfStream)
                    {
                        __tmp41_first = false;
                        string __tmp41Line = __tmp41Reader.ReadLine();
                        if (__tmp41Line == null)
                        {
                            __tmp41Line = "";
                        }
                        __out.Append(__tmp39Prefix);
                        __out.Append(__tmp41Line);
                    }
                }
                string __tmp42Line = ").mLazyAdd("; //708:35
                __out.Append(__tmp42Line);
                StringBuilder __tmp43 = new StringBuilder();
                __tmp43.Append(propDeclName);
                using(StreamReader __tmp43Reader = new StreamReader(this.__ToStream(__tmp43.ToString())))
                {
                    bool __tmp43_first = true;
                    while(__tmp43_first || !__tmp43Reader.EndOfStream)
                    {
                        __tmp43_first = false;
                        string __tmp43Line = __tmp43Reader.ReadLine();
                        if (__tmp43Line == null)
                        {
                            __tmp43Line = "";
                        }
                        __out.Append(__tmp43Line);
                    }
                }
                string __tmp44Line = ", metadslx.core.Lazy.create(() -> "; //708:60
                __out.Append(__tmp44Line);
                StringBuilder __tmp45 = new StringBuilder();
                __tmp45.Append(GenerateTypeOf(value));
                using(StreamReader __tmp45Reader = new StreamReader(this.__ToStream(__tmp45.ToString())))
                {
                    bool __tmp45_first = true;
                    while(__tmp45_first || !__tmp45Reader.EndOfStream)
                    {
                        __tmp45_first = false;
                        string __tmp45Line = __tmp45Reader.ReadLine();
                        if (__tmp45Line == null)
                        {
                            __tmp45Line = "";
                        }
                        __out.Append(__tmp45Line);
                        __out.Append(__tmp40Suffix);
                        __out.AppendLine(); //708:126
                    }
                }
            }
            else if (value is Enum) //709:2
            {
                string __tmp46Prefix = "((metadslx.core.ModelObject)"; //710:1
                string __tmp47Suffix = ", true));"; //710:119
                StringBuilder __tmp48 = new StringBuilder();
                __tmp48.Append(name);
                using(StreamReader __tmp48Reader = new StreamReader(this.__ToStream(__tmp48.ToString())))
                {
                    bool __tmp48_first = true;
                    while(__tmp48_first || !__tmp48Reader.EndOfStream)
                    {
                        __tmp48_first = false;
                        string __tmp48Line = __tmp48Reader.ReadLine();
                        if (__tmp48Line == null)
                        {
                            __tmp48Line = "";
                        }
                        __out.Append(__tmp46Prefix);
                        __out.Append(__tmp48Line);
                    }
                }
                string __tmp49Line = ").mLazyAdd("; //710:35
                __out.Append(__tmp49Line);
                StringBuilder __tmp50 = new StringBuilder();
                __tmp50.Append(propDeclName);
                using(StreamReader __tmp50Reader = new StreamReader(this.__ToStream(__tmp50.ToString())))
                {
                    bool __tmp50_first = true;
                    while(__tmp50_first || !__tmp50Reader.EndOfStream)
                    {
                        __tmp50_first = false;
                        string __tmp50Line = __tmp50Reader.ReadLine();
                        if (__tmp50Line == null)
                        {
                            __tmp50Line = "";
                        }
                        __out.Append(__tmp50Line);
                    }
                }
                string __tmp51Line = ", metadslx.core.Lazy.create(() -> "; //710:60
                __out.Append(__tmp51Line);
                StringBuilder __tmp52 = new StringBuilder();
                __tmp52.Append(value.JavaEnumValueOf());
                using(StreamReader __tmp52Reader = new StreamReader(this.__ToStream(__tmp52.ToString())))
                {
                    bool __tmp52_first = true;
                    while(__tmp52_first || !__tmp52Reader.EndOfStream)
                    {
                        __tmp52_first = false;
                        string __tmp52Line = __tmp52Reader.ReadLine();
                        if (__tmp52Line == null)
                        {
                            __tmp52Line = "";
                        }
                        __out.Append(__tmp52Line);
                        __out.Append(__tmp47Suffix);
                        __out.AppendLine(); //710:128
                    }
                }
            }
            else if (moValue != null) //711:2
            {
                if (mobjToName.ContainsKey(moValue)) //712:3
                {
                    string __tmp53Prefix = "((metadslx.core.ModelObject)"; //713:1
                    string __tmp54Suffix = ", true));"; //713:115
                    StringBuilder __tmp55 = new StringBuilder();
                    __tmp55.Append(name);
                    using(StreamReader __tmp55Reader = new StreamReader(this.__ToStream(__tmp55.ToString())))
                    {
                        bool __tmp55_first = true;
                        while(__tmp55_first || !__tmp55Reader.EndOfStream)
                        {
                            __tmp55_first = false;
                            string __tmp55Line = __tmp55Reader.ReadLine();
                            if (__tmp55Line == null)
                            {
                                __tmp55Line = "";
                            }
                            __out.Append(__tmp53Prefix);
                            __out.Append(__tmp55Line);
                        }
                    }
                    string __tmp56Line = ").mLazyAdd("; //713:35
                    __out.Append(__tmp56Line);
                    StringBuilder __tmp57 = new StringBuilder();
                    __tmp57.Append(propDeclName);
                    using(StreamReader __tmp57Reader = new StreamReader(this.__ToStream(__tmp57.ToString())))
                    {
                        bool __tmp57_first = true;
                        while(__tmp57_first || !__tmp57Reader.EndOfStream)
                        {
                            __tmp57_first = false;
                            string __tmp57Line = __tmp57Reader.ReadLine();
                            if (__tmp57Line == null)
                            {
                                __tmp57Line = "";
                            }
                            __out.Append(__tmp57Line);
                        }
                    }
                    string __tmp58Line = ", metadslx.core.Lazy.create(() -> "; //713:60
                    __out.Append(__tmp58Line);
                    StringBuilder __tmp59 = new StringBuilder();
                    __tmp59.Append(mobjToName[moValue]);
                    using(StreamReader __tmp59Reader = new StreamReader(this.__ToStream(__tmp59.ToString())))
                    {
                        bool __tmp59_first = true;
                        while(__tmp59_first || !__tmp59Reader.EndOfStream)
                        {
                            __tmp59_first = false;
                            string __tmp59Line = __tmp59Reader.ReadLine();
                            if (__tmp59Line == null)
                            {
                                __tmp59Line = "";
                            }
                            __out.Append(__tmp59Line);
                            __out.Append(__tmp54Suffix);
                            __out.AppendLine(); //713:124
                        }
                    }
                }
                else //714:3
                {
                    string __tmp60Prefix = "// Omitted since not part of the model: "; //715:1
                    string __tmp61Suffix = string.Empty; 
                    StringBuilder __tmp62 = new StringBuilder();
                    __tmp62.Append(name);
                    using(StreamReader __tmp62Reader = new StreamReader(this.__ToStream(__tmp62.ToString())))
                    {
                        bool __tmp62_first = true;
                        while(__tmp62_first || !__tmp62Reader.EndOfStream)
                        {
                            __tmp62_first = false;
                            string __tmp62Line = __tmp62Reader.ReadLine();
                            if (__tmp62Line == null)
                            {
                                __tmp62Line = "";
                            }
                            __out.Append(__tmp60Prefix);
                            __out.Append(__tmp62Line);
                        }
                    }
                    string __tmp63Line = "."; //715:47
                    __out.Append(__tmp63Line);
                    StringBuilder __tmp64 = new StringBuilder();
                    __tmp64.Append(propDeclName);
                    using(StreamReader __tmp64Reader = new StreamReader(this.__ToStream(__tmp64.ToString())))
                    {
                        bool __tmp64_first = true;
                        while(__tmp64_first || !__tmp64Reader.EndOfStream)
                        {
                            __tmp64_first = false;
                            string __tmp64Line = __tmp64Reader.ReadLine();
                            if (__tmp64Line == null)
                            {
                                __tmp64Line = "";
                            }
                            __out.Append(__tmp64Line);
                        }
                    }
                    string __tmp65Line = " = "; //715:62
                    __out.Append(__tmp65Line);
                    StringBuilder __tmp66 = new StringBuilder();
                    __tmp66.Append(moValue);
                    using(StreamReader __tmp66Reader = new StreamReader(this.__ToStream(__tmp66.ToString())))
                    {
                        bool __tmp66_first = true;
                        while(__tmp66_first || !__tmp66Reader.EndOfStream)
                        {
                            __tmp66_first = false;
                            string __tmp66Line = __tmp66Reader.ReadLine();
                            if (__tmp66Line == null)
                            {
                                __tmp66Line = "";
                            }
                            __out.Append(__tmp66Line);
                            __out.Append(__tmp61Suffix);
                            __out.AppendLine(); //715:74
                        }
                    }
                }
            }
            else //717:2
            {
                IEnumerable<object> mc = (value as ModelCollection) as IEnumerable<object>; //718:3
                if (mc != null) //719:3
                {
                    var __loop41_results = 
                        (from cvalue in __Enumerate((mc).GetEnumerator()) //720:9
                        select new { cvalue = cvalue}
                        ).ToList(); //720:4
                    int __loop41_iteration = 0;
                    foreach (var __tmp67 in __loop41_results)
                    {
                        ++__loop41_iteration;
                        var cvalue = __tmp67.cvalue;
                        if (!mobj.ContainedBySingleOpposite(prop, (ModelObject)cvalue)) //721:5
                        {
                            string __tmp68Prefix = string.Empty;
                            string __tmp69Suffix = string.Empty;
                            StringBuilder __tmp70 = new StringBuilder();
                            __tmp70.Append(GenerateModelObjectPropertyValue(mobj, prop, cvalue, mobjToName));
                            using(StreamReader __tmp70Reader = new StreamReader(this.__ToStream(__tmp70.ToString())))
                            {
                                bool __tmp70_first = true;
                                while(__tmp70_first || !__tmp70Reader.EndOfStream)
                                {
                                    __tmp70_first = false;
                                    string __tmp70Line = __tmp70Reader.ReadLine();
                                    if (__tmp70Line == null)
                                    {
                                        __tmp70Line = "";
                                    }
                                    __out.Append(__tmp68Prefix);
                                    __out.Append(__tmp70Line);
                                    __out.Append(__tmp69Suffix);
                                    __out.AppendLine(); //722:67
                                }
                            }
                        }
                    }
                }
                else //725:3
                {
                    string __tmp71Prefix = "// Invalid property value type: "; //726:1
                    string __tmp72Suffix = string.Empty; 
                    StringBuilder __tmp73 = new StringBuilder();
                    __tmp73.Append(name);
                    using(StreamReader __tmp73Reader = new StreamReader(this.__ToStream(__tmp73.ToString())))
                    {
                        bool __tmp73_first = true;
                        while(__tmp73_first || !__tmp73Reader.EndOfStream)
                        {
                            __tmp73_first = false;
                            string __tmp73Line = __tmp73Reader.ReadLine();
                            if (__tmp73Line == null)
                            {
                                __tmp73Line = "";
                            }
                            __out.Append(__tmp71Prefix);
                            __out.Append(__tmp73Line);
                        }
                    }
                    string __tmp74Line = "."; //726:39
                    __out.Append(__tmp74Line);
                    StringBuilder __tmp75 = new StringBuilder();
                    __tmp75.Append(propDeclName);
                    using(StreamReader __tmp75Reader = new StreamReader(this.__ToStream(__tmp75.ToString())))
                    {
                        bool __tmp75_first = true;
                        while(__tmp75_first || !__tmp75Reader.EndOfStream)
                        {
                            __tmp75_first = false;
                            string __tmp75Line = __tmp75Reader.ReadLine();
                            if (__tmp75Line == null)
                            {
                                __tmp75Line = "";
                            }
                            __out.Append(__tmp75Line);
                        }
                    }
                    string __tmp76Line = " = "; //726:54
                    __out.Append(__tmp76Line);
                    StringBuilder __tmp77 = new StringBuilder();
                    __tmp77.Append(value.GetType());
                    using(StreamReader __tmp77Reader = new StreamReader(this.__ToStream(__tmp77.ToString())))
                    {
                        bool __tmp77_first = true;
                        while(__tmp77_first || !__tmp77Reader.EndOfStream)
                        {
                            __tmp77_first = false;
                            string __tmp77Line = __tmp77Reader.ReadLine();
                            if (__tmp77Line == null)
                            {
                                __tmp77Line = "";
                            }
                            __out.Append(__tmp77Line);
                            __out.Append(__tmp72Suffix);
                            __out.AppendLine(); //726:74
                        }
                    }
                }
            }
            return __out.ToString();
        }

        public string GenerateImplementationProvider(MetaModel model) //732:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //733:1
            string __tmp2Suffix = ";"; //733:37
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(model.Namespace.JavaName());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //733:38
                }
            }
            __out.AppendLine(); //734:1
            string __tmp4Prefix = "final class "; //735:1
            string __tmp5Suffix = "ImplementationProvider {"; //735:25
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(model.Name);
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //735:49
                }
            }
            string __tmp7Prefix = "    // If there is a compile error at this line, create a new class called "; //736:1
            string __tmp8Suffix = "Implementation"; //736:88
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(model.Name);
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                while(__tmp9_first || !__tmp9Reader.EndOfStream)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    if (__tmp9Line == null)
                    {
                        __tmp9Line = "";
                    }
                    __out.Append(__tmp7Prefix);
                    __out.Append(__tmp9Line);
                    __out.Append(__tmp8Suffix);
                    __out.AppendLine(); //736:102
                }
            }
            string __tmp10Prefix = "	// which is a subclass of "; //737:1
            string __tmp11Suffix = "ImplementationBase:"; //737:40
            StringBuilder __tmp12 = new StringBuilder();
            __tmp12.Append(model.Name);
            using(StreamReader __tmp12Reader = new StreamReader(this.__ToStream(__tmp12.ToString())))
            {
                bool __tmp12_first = true;
                while(__tmp12_first || !__tmp12Reader.EndOfStream)
                {
                    __tmp12_first = false;
                    string __tmp12Line = __tmp12Reader.ReadLine();
                    if (__tmp12Line == null)
                    {
                        __tmp12Line = "";
                    }
                    __out.Append(__tmp10Prefix);
                    __out.Append(__tmp12Line);
                    __out.Append(__tmp11Suffix);
                    __out.AppendLine(); //737:59
                }
            }
            string __tmp13Prefix = "    private static "; //738:1
            string __tmp14Suffix = "Implementation();"; //738:80
            StringBuilder __tmp15 = new StringBuilder();
            __tmp15.Append(model.Name);
            using(StreamReader __tmp15Reader = new StreamReader(this.__ToStream(__tmp15.ToString())))
            {
                bool __tmp15_first = true;
                while(__tmp15_first || !__tmp15Reader.EndOfStream)
                {
                    __tmp15_first = false;
                    string __tmp15Line = __tmp15Reader.ReadLine();
                    if (__tmp15Line == null)
                    {
                        __tmp15Line = "";
                    }
                    __out.Append(__tmp13Prefix);
                    __out.Append(__tmp15Line);
                }
            }
            string __tmp16Line = "Implementation implementation = new "; //738:32
            __out.Append(__tmp16Line);
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(model.Name);
            using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
            {
                bool __tmp17_first = true;
                while(__tmp17_first || !__tmp17Reader.EndOfStream)
                {
                    __tmp17_first = false;
                    string __tmp17Line = __tmp17Reader.ReadLine();
                    if (__tmp17Line == null)
                    {
                        __tmp17Line = "";
                    }
                    __out.Append(__tmp17Line);
                    __out.Append(__tmp14Suffix);
                    __out.AppendLine(); //738:97
                }
            }
            __out.AppendLine(); //739:1
            string __tmp18Prefix = "    public static "; //740:1
            string __tmp19Suffix = "Implementation implementation() {"; //740:31
            StringBuilder __tmp20 = new StringBuilder();
            __tmp20.Append(model.Name);
            using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
            {
                bool __tmp20_first = true;
                while(__tmp20_first || !__tmp20Reader.EndOfStream)
                {
                    __tmp20_first = false;
                    string __tmp20Line = __tmp20Reader.ReadLine();
                    if (__tmp20Line == null)
                    {
                        __tmp20Line = "";
                    }
                    __out.Append(__tmp18Prefix);
                    __out.Append(__tmp20Line);
                    __out.Append(__tmp19Suffix);
                    __out.AppendLine(); //740:64
                }
            }
            string __tmp21Prefix = "        return "; //741:1
            string __tmp22Suffix = "ImplementationProvider.implementation;"; //741:28
            StringBuilder __tmp23 = new StringBuilder();
            __tmp23.Append(model.Name);
            using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
            {
                bool __tmp23_first = true;
                while(__tmp23_first || !__tmp23Reader.EndOfStream)
                {
                    __tmp23_first = false;
                    string __tmp23Line = __tmp23Reader.ReadLine();
                    if (__tmp23Line == null)
                    {
                        __tmp23Line = "";
                    }
                    __out.Append(__tmp21Prefix);
                    __out.Append(__tmp23Line);
                    __out.Append(__tmp22Suffix);
                    __out.AppendLine(); //741:66
                }
            }
            __out.Append("    }"); //742:1
            __out.AppendLine(); //742:6
            __out.Append("}"); //743:1
            __out.AppendLine(); //743:2
            return __out.ToString();
        }

        public string GenerateImplementationBase(MetaModel model) //746:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //747:1
            string __tmp2Suffix = ";"; //747:37
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(model.Namespace.JavaName());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //747:38
                }
            }
            __out.AppendLine(); //748:1
            __out.Append("/**"); //749:1
            __out.AppendLine(); //749:4
            __out.Append(" * Base class for implementing the behavior of the model elements."); //750:1
            __out.AppendLine(); //750:67
            string __tmp4Prefix = " * This class has to be be overriden in "; //751:1
            string __tmp5Suffix = "Implementation to provide custom"; //751:53
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(model.Name);
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //751:85
                }
            }
            __out.Append(" * implementation for the constructors, operations and property values."); //752:1
            __out.AppendLine(); //752:72
            __out.Append(" */"); //753:1
            __out.AppendLine(); //753:4
            string __tmp7Prefix = "abstract class "; //754:1
            string __tmp8Suffix = "ImplementationBase {"; //754:28
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(model.Name);
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                while(__tmp9_first || !__tmp9Reader.EndOfStream)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    if (__tmp9Line == null)
                    {
                        __tmp9Line = "";
                    }
                    __out.Append(__tmp7Prefix);
                    __out.Append(__tmp9Line);
                    __out.Append(__tmp8Suffix);
                    __out.AppendLine(); //754:48
                }
            }
            var __loop42_results = 
                (from __loop42_var1 in __Enumerate((model).GetEnumerator()) //755:8
                from Namespace in __Enumerate((__loop42_var1.Namespace).GetEnumerator()) //755:15
                from Declarations in __Enumerate((Namespace.Declarations).GetEnumerator()) //755:26
                from cls in __Enumerate((Declarations).GetEnumerator()).OfType<MetaClass>() //755:40
                select new { __loop42_var1 = __loop42_var1, Namespace = Namespace, Declarations = Declarations, cls = cls}
                ).ToList(); //755:3
            int __loop42_iteration = 0;
            foreach (var __tmp10 in __loop42_results)
            {
                ++__loop42_iteration;
                var __loop42_var1 = __tmp10.__loop42_var1;
                var Namespace = __tmp10.Namespace;
                var Declarations = __tmp10.Declarations;
                var cls = __tmp10.cls;
                __out.Append("    /**"); //756:1
                __out.AppendLine(); //756:8
                string __tmp11Prefix = "	 * Implements the constructor: "; //757:1
                string __tmp12Suffix = "()"; //757:49
                StringBuilder __tmp13 = new StringBuilder();
                __tmp13.Append(cls.JavaName());
                using(StreamReader __tmp13Reader = new StreamReader(this.__ToStream(__tmp13.ToString())))
                {
                    bool __tmp13_first = true;
                    while(__tmp13_first || !__tmp13Reader.EndOfStream)
                    {
                        __tmp13_first = false;
                        string __tmp13Line = __tmp13Reader.ReadLine();
                        if (__tmp13Line == null)
                        {
                            __tmp13Line = "";
                        }
                        __out.Append(__tmp11Prefix);
                        __out.Append(__tmp13Line);
                        __out.Append(__tmp12Suffix);
                        __out.AppendLine(); //757:51
                    }
                }
                if ((from __loop43_var1 in __Enumerate((cls).GetEnumerator()) //758:15
                from sup in __Enumerate((__loop43_var1.SuperClasses).GetEnumerator()) //758:20
                select new { __loop43_var1 = __loop43_var1, sup = sup}
                ).GetEnumerator().MoveNext()) //758:3
                {
                    string __tmp14Prefix = "	 * Direct superclasses: "; //759:1
                    string __tmp15Suffix = string.Empty; 
                    StringBuilder __tmp16 = new StringBuilder();
                    __tmp16.Append(GetSuperClasses(cls));
                    using(StreamReader __tmp16Reader = new StreamReader(this.__ToStream(__tmp16.ToString())))
                    {
                        bool __tmp16_first = true;
                        while(__tmp16_first || !__tmp16Reader.EndOfStream)
                        {
                            __tmp16_first = false;
                            string __tmp16Line = __tmp16Reader.ReadLine();
                            if (__tmp16Line == null)
                            {
                                __tmp16Line = "";
                            }
                            __out.Append(__tmp14Prefix);
                            __out.Append(__tmp16Line);
                            __out.Append(__tmp15Suffix);
                            __out.AppendLine(); //759:48
                        }
                    }
                    string __tmp17Prefix = "	 * All superclasses: "; //760:1
                    string __tmp18Suffix = string.Empty; 
                    StringBuilder __tmp19 = new StringBuilder();
                    __tmp19.Append(GetAllSuperClasses(cls));
                    using(StreamReader __tmp19Reader = new StreamReader(this.__ToStream(__tmp19.ToString())))
                    {
                        bool __tmp19_first = true;
                        while(__tmp19_first || !__tmp19Reader.EndOfStream)
                        {
                            __tmp19_first = false;
                            string __tmp19Line = __tmp19Reader.ReadLine();
                            if (__tmp19Line == null)
                            {
                                __tmp19Line = "";
                            }
                            __out.Append(__tmp17Prefix);
                            __out.Append(__tmp19Line);
                            __out.Append(__tmp18Suffix);
                            __out.AppendLine(); //760:48
                        }
                    }
                }
                if ((from __loop44_var1 in __Enumerate((cls).GetEnumerator()) //762:15
                from prop in __Enumerate((__loop44_var1.GetAllProperties()).GetEnumerator()) //762:20
                where prop.Kind == MetaPropertyKind.Readonly //762:44
                select new { __loop44_var1 = __loop44_var1, prop = prop}
                ).GetEnumerator().MoveNext()) //762:3
                {
                    __out.Append("     * Initializes the following readonly properties:"); //763:1
                    __out.AppendLine(); //763:54
                }
                var __loop45_results = 
                    (from __loop45_var1 in __Enumerate((cls).GetEnumerator()) //765:11
                    from prop in __Enumerate((__loop45_var1.GetAllProperties()).GetEnumerator()) //765:16
                    select new { __loop45_var1 = __loop45_var1, prop = prop}
                    ).ToList(); //765:6
                int __loop45_iteration = 0;
                foreach (var __tmp20 in __loop45_results)
                {
                    ++__loop45_iteration;
                    var __loop45_var1 = __tmp20.__loop45_var1;
                    var prop = __tmp20.prop;
                    if (prop.Kind == MetaPropertyKind.Readonly) //766:3
                    {
                        string __tmp21Prefix = "     *    "; //767:1
                        string __tmp22Suffix = string.Empty; 
                        StringBuilder __tmp23 = new StringBuilder();
                        __tmp23.Append(prop.Class.Name);
                        using(StreamReader __tmp23Reader = new StreamReader(this.__ToStream(__tmp23.ToString())))
                        {
                            bool __tmp23_first = true;
                            while(__tmp23_first || !__tmp23Reader.EndOfStream)
                            {
                                __tmp23_first = false;
                                string __tmp23Line = __tmp23Reader.ReadLine();
                                if (__tmp23Line == null)
                                {
                                    __tmp23Line = "";
                                }
                                __out.Append(__tmp21Prefix);
                                __out.Append(__tmp23Line);
                            }
                        }
                        string __tmp24Line = "."; //767:28
                        __out.Append(__tmp24Line);
                        StringBuilder __tmp25 = new StringBuilder();
                        __tmp25.Append(prop.Name);
                        using(StreamReader __tmp25Reader = new StreamReader(this.__ToStream(__tmp25.ToString())))
                        {
                            bool __tmp25_first = true;
                            while(__tmp25_first || !__tmp25Reader.EndOfStream)
                            {
                                __tmp25_first = false;
                                string __tmp25Line = __tmp25Reader.ReadLine();
                                if (__tmp25Line == null)
                                {
                                    __tmp25Line = "";
                                }
                                __out.Append(__tmp25Line);
                                __out.Append(__tmp22Suffix);
                                __out.AppendLine(); //767:40
                            }
                        }
                    }
                }
                __out.Append("    */"); //770:1
                __out.AppendLine(); //770:7
                string __tmp26Prefix = "    public void "; //771:1
                string __tmp27Suffix = " _this) {"; //771:50
                StringBuilder __tmp28 = new StringBuilder();
                __tmp28.Append(cls.JavaName());
                using(StreamReader __tmp28Reader = new StreamReader(this.__ToStream(__tmp28.ToString())))
                {
                    bool __tmp28_first = true;
                    while(__tmp28_first || !__tmp28Reader.EndOfStream)
                    {
                        __tmp28_first = false;
                        string __tmp28Line = __tmp28Reader.ReadLine();
                        if (__tmp28Line == null)
                        {
                            __tmp28Line = "";
                        }
                        __out.Append(__tmp26Prefix);
                        __out.Append(__tmp28Line);
                    }
                }
                string __tmp29Line = "("; //771:33
                __out.Append(__tmp29Line);
                StringBuilder __tmp30 = new StringBuilder();
                __tmp30.Append(cls.JavaName());
                using(StreamReader __tmp30Reader = new StreamReader(this.__ToStream(__tmp30.ToString())))
                {
                    bool __tmp30_first = true;
                    while(__tmp30_first || !__tmp30Reader.EndOfStream)
                    {
                        __tmp30_first = false;
                        string __tmp30Line = __tmp30Reader.ReadLine();
                        if (__tmp30Line == null)
                        {
                            __tmp30Line = "";
                        }
                        __out.Append(__tmp30Line);
                        __out.Append(__tmp27Suffix);
                        __out.AppendLine(); //771:59
                    }
                }
                var __loop46_results = 
                    (from __loop46_var1 in __Enumerate((cls).GetEnumerator()) //772:9
                    from sup in __Enumerate((__loop46_var1.SuperClasses).GetEnumerator()) //772:14
                    select new { __loop46_var1 = __loop46_var1, sup = sup}
                    ).ToList(); //772:4
                int __loop46_iteration = 0;
                foreach (var __tmp31 in __loop46_results)
                {
                    ++__loop46_iteration;
                    var __loop46_var1 = __tmp31.__loop46_var1;
                    var sup = __tmp31.sup;
                    string __tmp32Prefix = "        this."; //773:1
                    string __tmp33Suffix = "(_this);"; //773:30
                    StringBuilder __tmp34 = new StringBuilder();
                    __tmp34.Append(sup.JavaName());
                    using(StreamReader __tmp34Reader = new StreamReader(this.__ToStream(__tmp34.ToString())))
                    {
                        bool __tmp34_first = true;
                        while(__tmp34_first || !__tmp34Reader.EndOfStream)
                        {
                            __tmp34_first = false;
                            string __tmp34Line = __tmp34Reader.ReadLine();
                            if (__tmp34Line == null)
                            {
                                __tmp34Line = "";
                            }
                            __out.Append(__tmp32Prefix);
                            __out.Append(__tmp34Line);
                            __out.Append(__tmp33Suffix);
                            __out.AppendLine(); //773:38
                        }
                    }
                }
                __out.Append("    }"); //775:1
                __out.AppendLine(); //775:6
                var __loop47_results = 
                    (from __loop47_var1 in __Enumerate((cls).GetEnumerator()) //776:11
                    from prop in __Enumerate((__loop47_var1.Properties).GetEnumerator()) //776:16
                    select new { __loop47_var1 = __loop47_var1, prop = prop}
                    ).ToList(); //776:6
                int __loop47_iteration = 0;
                foreach (var __tmp35 in __loop47_results)
                {
                    ++__loop47_iteration;
                    var __loop47_var1 = __tmp35.__loop47_var1;
                    var prop = __tmp35.prop;
                    MetaSynthetizedPropertyInitializer synInit = GetSynthetizedInitializerFor(cls, prop); //777:4
                    if (synInit == null) //778:4
                    {
                        if (prop.Kind == MetaPropertyKind.Derived) //779:5
                        {
                            __out.AppendLine(); //780:1
                            __out.Append("    /**"); //781:1
                            __out.AppendLine(); //781:8
                            string __tmp36Prefix = "     * Returns the value of the derived property: "; //782:1
                            string __tmp37Suffix = string.Empty; 
                            StringBuilder __tmp38 = new StringBuilder();
                            __tmp38.Append(cls.JavaName());
                            using(StreamReader __tmp38Reader = new StreamReader(this.__ToStream(__tmp38.ToString())))
                            {
                                bool __tmp38_first = true;
                                while(__tmp38_first || !__tmp38Reader.EndOfStream)
                                {
                                    __tmp38_first = false;
                                    string __tmp38Line = __tmp38Reader.ReadLine();
                                    if (__tmp38Line == null)
                                    {
                                        __tmp38Line = "";
                                    }
                                    __out.Append(__tmp36Prefix);
                                    __out.Append(__tmp38Line);
                                }
                            }
                            string __tmp39Line = "."; //782:67
                            __out.Append(__tmp39Line);
                            StringBuilder __tmp40 = new StringBuilder();
                            __tmp40.Append(prop.Name);
                            using(StreamReader __tmp40Reader = new StreamReader(this.__ToStream(__tmp40.ToString())))
                            {
                                bool __tmp40_first = true;
                                while(__tmp40_first || !__tmp40Reader.EndOfStream)
                                {
                                    __tmp40_first = false;
                                    string __tmp40Line = __tmp40Reader.ReadLine();
                                    if (__tmp40Line == null)
                                    {
                                        __tmp40Line = "";
                                    }
                                    __out.Append(__tmp40Line);
                                    __out.Append(__tmp37Suffix);
                                    __out.AppendLine(); //782:79
                                }
                            }
                            __out.Append("     */"); //783:1
                            __out.AppendLine(); //783:8
                            string __tmp41Prefix = "    public "; //784:1
                            string __tmp42Suffix = " _this) {"; //784:90
                            StringBuilder __tmp43 = new StringBuilder();
                            __tmp43.Append(prop.Type.JavaFullPublicName());
                            using(StreamReader __tmp43Reader = new StreamReader(this.__ToStream(__tmp43.ToString())))
                            {
                                bool __tmp43_first = true;
                                while(__tmp43_first || !__tmp43Reader.EndOfStream)
                                {
                                    __tmp43_first = false;
                                    string __tmp43Line = __tmp43Reader.ReadLine();
                                    if (__tmp43Line == null)
                                    {
                                        __tmp43Line = "";
                                    }
                                    __out.Append(__tmp41Prefix);
                                    __out.Append(__tmp43Line);
                                }
                            }
                            string __tmp44Line = " "; //784:44
                            __out.Append(__tmp44Line);
                            StringBuilder __tmp45 = new StringBuilder();
                            __tmp45.Append(cls.JavaName());
                            using(StreamReader __tmp45Reader = new StreamReader(this.__ToStream(__tmp45.ToString())))
                            {
                                bool __tmp45_first = true;
                                while(__tmp45_first || !__tmp45Reader.EndOfStream)
                                {
                                    __tmp45_first = false;
                                    string __tmp45Line = __tmp45Reader.ReadLine();
                                    if (__tmp45Line == null)
                                    {
                                        __tmp45Line = "";
                                    }
                                    __out.Append(__tmp45Line);
                                }
                            }
                            string __tmp46Line = "_"; //784:61
                            __out.Append(__tmp46Line);
                            StringBuilder __tmp47 = new StringBuilder();
                            __tmp47.Append(prop.Name);
                            using(StreamReader __tmp47Reader = new StreamReader(this.__ToStream(__tmp47.ToString())))
                            {
                                bool __tmp47_first = true;
                                while(__tmp47_first || !__tmp47Reader.EndOfStream)
                                {
                                    __tmp47_first = false;
                                    string __tmp47Line = __tmp47Reader.ReadLine();
                                    if (__tmp47Line == null)
                                    {
                                        __tmp47Line = "";
                                    }
                                    __out.Append(__tmp47Line);
                                }
                            }
                            string __tmp48Line = "("; //784:73
                            __out.Append(__tmp48Line);
                            StringBuilder __tmp49 = new StringBuilder();
                            __tmp49.Append(cls.JavaName());
                            using(StreamReader __tmp49Reader = new StreamReader(this.__ToStream(__tmp49.ToString())))
                            {
                                bool __tmp49_first = true;
                                while(__tmp49_first || !__tmp49Reader.EndOfStream)
                                {
                                    __tmp49_first = false;
                                    string __tmp49Line = __tmp49Reader.ReadLine();
                                    if (__tmp49Line == null)
                                    {
                                        __tmp49Line = "";
                                    }
                                    __out.Append(__tmp49Line);
                                    __out.Append(__tmp42Suffix);
                                    __out.AppendLine(); //784:99
                                }
                            }
                            __out.Append("        throw new UnsupportedOperationException();"); //785:1
                            __out.AppendLine(); //785:51
                            __out.Append("    }"); //786:1
                            __out.AppendLine(); //786:6
                        }
                        else if (prop.Kind == MetaPropertyKind.Lazy) //787:5
                        {
                            __out.AppendLine(); //788:1
                            __out.Append("    /**"); //789:1
                            __out.AppendLine(); //789:8
                            string __tmp50Prefix = "     * Returns the value of the lazy property: "; //790:1
                            string __tmp51Suffix = string.Empty; 
                            StringBuilder __tmp52 = new StringBuilder();
                            __tmp52.Append(cls.JavaName());
                            using(StreamReader __tmp52Reader = new StreamReader(this.__ToStream(__tmp52.ToString())))
                            {
                                bool __tmp52_first = true;
                                while(__tmp52_first || !__tmp52Reader.EndOfStream)
                                {
                                    __tmp52_first = false;
                                    string __tmp52Line = __tmp52Reader.ReadLine();
                                    if (__tmp52Line == null)
                                    {
                                        __tmp52Line = "";
                                    }
                                    __out.Append(__tmp50Prefix);
                                    __out.Append(__tmp52Line);
                                }
                            }
                            string __tmp53Line = "."; //790:64
                            __out.Append(__tmp53Line);
                            StringBuilder __tmp54 = new StringBuilder();
                            __tmp54.Append(prop.Name);
                            using(StreamReader __tmp54Reader = new StreamReader(this.__ToStream(__tmp54.ToString())))
                            {
                                bool __tmp54_first = true;
                                while(__tmp54_first || !__tmp54Reader.EndOfStream)
                                {
                                    __tmp54_first = false;
                                    string __tmp54Line = __tmp54Reader.ReadLine();
                                    if (__tmp54Line == null)
                                    {
                                        __tmp54Line = "";
                                    }
                                    __out.Append(__tmp54Line);
                                    __out.Append(__tmp51Suffix);
                                    __out.AppendLine(); //790:76
                                }
                            }
                            __out.Append("     */"); //791:1
                            __out.AppendLine(); //791:8
                            string __tmp55Prefix = "    public "; //792:1
                            string __tmp56Suffix = " _this) {"; //792:90
                            StringBuilder __tmp57 = new StringBuilder();
                            __tmp57.Append(prop.Type.JavaFullPublicName());
                            using(StreamReader __tmp57Reader = new StreamReader(this.__ToStream(__tmp57.ToString())))
                            {
                                bool __tmp57_first = true;
                                while(__tmp57_first || !__tmp57Reader.EndOfStream)
                                {
                                    __tmp57_first = false;
                                    string __tmp57Line = __tmp57Reader.ReadLine();
                                    if (__tmp57Line == null)
                                    {
                                        __tmp57Line = "";
                                    }
                                    __out.Append(__tmp55Prefix);
                                    __out.Append(__tmp57Line);
                                }
                            }
                            string __tmp58Line = " "; //792:44
                            __out.Append(__tmp58Line);
                            StringBuilder __tmp59 = new StringBuilder();
                            __tmp59.Append(cls.JavaName());
                            using(StreamReader __tmp59Reader = new StreamReader(this.__ToStream(__tmp59.ToString())))
                            {
                                bool __tmp59_first = true;
                                while(__tmp59_first || !__tmp59Reader.EndOfStream)
                                {
                                    __tmp59_first = false;
                                    string __tmp59Line = __tmp59Reader.ReadLine();
                                    if (__tmp59Line == null)
                                    {
                                        __tmp59Line = "";
                                    }
                                    __out.Append(__tmp59Line);
                                }
                            }
                            string __tmp60Line = "_"; //792:61
                            __out.Append(__tmp60Line);
                            StringBuilder __tmp61 = new StringBuilder();
                            __tmp61.Append(prop.Name);
                            using(StreamReader __tmp61Reader = new StreamReader(this.__ToStream(__tmp61.ToString())))
                            {
                                bool __tmp61_first = true;
                                while(__tmp61_first || !__tmp61Reader.EndOfStream)
                                {
                                    __tmp61_first = false;
                                    string __tmp61Line = __tmp61Reader.ReadLine();
                                    if (__tmp61Line == null)
                                    {
                                        __tmp61Line = "";
                                    }
                                    __out.Append(__tmp61Line);
                                }
                            }
                            string __tmp62Line = "("; //792:73
                            __out.Append(__tmp62Line);
                            StringBuilder __tmp63 = new StringBuilder();
                            __tmp63.Append(cls.JavaName());
                            using(StreamReader __tmp63Reader = new StreamReader(this.__ToStream(__tmp63.ToString())))
                            {
                                bool __tmp63_first = true;
                                while(__tmp63_first || !__tmp63Reader.EndOfStream)
                                {
                                    __tmp63_first = false;
                                    string __tmp63Line = __tmp63Reader.ReadLine();
                                    if (__tmp63Line == null)
                                    {
                                        __tmp63Line = "";
                                    }
                                    __out.Append(__tmp63Line);
                                    __out.Append(__tmp56Suffix);
                                    __out.AppendLine(); //792:99
                                }
                            }
                            __out.Append("        throw new UnsupportedOperationException();"); //793:1
                            __out.AppendLine(); //793:51
                            __out.Append("    }"); //794:1
                            __out.AppendLine(); //794:6
                        }
                    }
                }
                var __loop48_results = 
                    (from __loop48_var1 in __Enumerate((cls).GetEnumerator()) //798:11
                    from op in __Enumerate((__loop48_var1.Operations).GetEnumerator()) //798:16
                    select new { __loop48_var1 = __loop48_var1, op = op}
                    ).ToList(); //798:6
                int __loop48_iteration = 0;
                foreach (var __tmp64 in __loop48_results)
                {
                    ++__loop48_iteration;
                    var __loop48_var1 = __tmp64.__loop48_var1;
                    var op = __tmp64.op;
                    __out.AppendLine(); //799:1
                    __out.Append("    /**"); //800:1
                    __out.AppendLine(); //800:8
                    string __tmp65Prefix = "     * Implements the operation: "; //801:1
                    string __tmp66Suffix = "()"; //801:60
                    StringBuilder __tmp67 = new StringBuilder();
                    __tmp67.Append(cls.JavaName());
                    using(StreamReader __tmp67Reader = new StreamReader(this.__ToStream(__tmp67.ToString())))
                    {
                        bool __tmp67_first = true;
                        while(__tmp67_first || !__tmp67Reader.EndOfStream)
                        {
                            __tmp67_first = false;
                            string __tmp67Line = __tmp67Reader.ReadLine();
                            if (__tmp67Line == null)
                            {
                                __tmp67Line = "";
                            }
                            __out.Append(__tmp65Prefix);
                            __out.Append(__tmp67Line);
                        }
                    }
                    string __tmp68Line = "."; //801:50
                    __out.Append(__tmp68Line);
                    StringBuilder __tmp69 = new StringBuilder();
                    __tmp69.Append(op.Name);
                    using(StreamReader __tmp69Reader = new StreamReader(this.__ToStream(__tmp69.ToString())))
                    {
                        bool __tmp69_first = true;
                        while(__tmp69_first || !__tmp69Reader.EndOfStream)
                        {
                            __tmp69_first = false;
                            string __tmp69Line = __tmp69Reader.ReadLine();
                            if (__tmp69Line == null)
                            {
                                __tmp69Line = "";
                            }
                            __out.Append(__tmp69Line);
                            __out.Append(__tmp66Suffix);
                            __out.AppendLine(); //801:62
                        }
                    }
                    __out.Append("     */"); //802:1
                    __out.AppendLine(); //802:8
                    string __tmp70Prefix = "    public "; //803:1
                    string __tmp71Suffix = ") {"; //803:118
                    StringBuilder __tmp72 = new StringBuilder();
                    __tmp72.Append(op.ReturnType.JavaFullPublicName());
                    using(StreamReader __tmp72Reader = new StreamReader(this.__ToStream(__tmp72.ToString())))
                    {
                        bool __tmp72_first = true;
                        while(__tmp72_first || !__tmp72Reader.EndOfStream)
                        {
                            __tmp72_first = false;
                            string __tmp72Line = __tmp72Reader.ReadLine();
                            if (__tmp72Line == null)
                            {
                                __tmp72Line = "";
                            }
                            __out.Append(__tmp70Prefix);
                            __out.Append(__tmp72Line);
                        }
                    }
                    string __tmp73Line = " "; //803:48
                    __out.Append(__tmp73Line);
                    StringBuilder __tmp74 = new StringBuilder();
                    __tmp74.Append(cls.JavaName());
                    using(StreamReader __tmp74Reader = new StreamReader(this.__ToStream(__tmp74.ToString())))
                    {
                        bool __tmp74_first = true;
                        while(__tmp74_first || !__tmp74Reader.EndOfStream)
                        {
                            __tmp74_first = false;
                            string __tmp74Line = __tmp74Reader.ReadLine();
                            if (__tmp74Line == null)
                            {
                                __tmp74Line = "";
                            }
                            __out.Append(__tmp74Line);
                        }
                    }
                    string __tmp75Line = "_"; //803:65
                    __out.Append(__tmp75Line);
                    StringBuilder __tmp76 = new StringBuilder();
                    __tmp76.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp76Reader = new StreamReader(this.__ToStream(__tmp76.ToString())))
                    {
                        bool __tmp76_first = true;
                        while(__tmp76_first || !__tmp76Reader.EndOfStream)
                        {
                            __tmp76_first = false;
                            string __tmp76Line = __tmp76Reader.ReadLine();
                            if (__tmp76Line == null)
                            {
                                __tmp76Line = "";
                            }
                            __out.Append(__tmp76Line);
                        }
                    }
                    string __tmp77Line = "("; //803:89
                    __out.Append(__tmp77Line);
                    StringBuilder __tmp78 = new StringBuilder();
                    __tmp78.Append(GetImplParameters(cls, op));
                    using(StreamReader __tmp78Reader = new StreamReader(this.__ToStream(__tmp78.ToString())))
                    {
                        bool __tmp78_first = true;
                        while(__tmp78_first || !__tmp78Reader.EndOfStream)
                        {
                            __tmp78_first = false;
                            string __tmp78Line = __tmp78Reader.ReadLine();
                            if (__tmp78Line == null)
                            {
                                __tmp78Line = "";
                            }
                            __out.Append(__tmp78Line);
                            __out.Append(__tmp71Suffix);
                            __out.AppendLine(); //803:121
                        }
                    }
                    __out.Append("        throw new UnsupportedOperationException();"); //804:1
                    __out.AppendLine(); //804:51
                    __out.Append("    }"); //805:1
                    __out.AppendLine(); //805:6
                }
                __out.AppendLine(); //807:1
            }
            var __loop49_results = 
                (from __loop49_var1 in __Enumerate((model).GetEnumerator()) //809:8
                from Namespace in __Enumerate((__loop49_var1.Namespace).GetEnumerator()) //809:15
                from Declarations in __Enumerate((Namespace.Declarations).GetEnumerator()) //809:26
                from enm in __Enumerate((Declarations).GetEnumerator()).OfType<MetaEnum>() //809:40
                select new { __loop49_var1 = __loop49_var1, Namespace = Namespace, Declarations = Declarations, enm = enm}
                ).ToList(); //809:3
            int __loop49_iteration = 0;
            foreach (var __tmp79 in __loop49_results)
            {
                ++__loop49_iteration;
                var __loop49_var1 = __tmp79.__loop49_var1;
                var Namespace = __tmp79.Namespace;
                var Declarations = __tmp79.Declarations;
                var enm = __tmp79.enm;
                var __loop50_results = 
                    (from __loop50_var1 in __Enumerate((enm).GetEnumerator()) //810:11
                    from op in __Enumerate((__loop50_var1.Operations).GetEnumerator()) //810:16
                    select new { __loop50_var1 = __loop50_var1, op = op}
                    ).ToList(); //810:6
                int __loop50_iteration = 0;
                foreach (var __tmp80 in __loop50_results)
                {
                    ++__loop50_iteration;
                    var __loop50_var1 = __tmp80.__loop50_var1;
                    var op = __tmp80.op;
                    __out.AppendLine(); //811:1
                    __out.Append("    /**"); //812:1
                    __out.AppendLine(); //812:8
                    string __tmp81Prefix = "     * Implements the operation: "; //813:1
                    string __tmp82Suffix = string.Empty; 
                    StringBuilder __tmp83 = new StringBuilder();
                    __tmp83.Append(enm.JavaName());
                    using(StreamReader __tmp83Reader = new StreamReader(this.__ToStream(__tmp83.ToString())))
                    {
                        bool __tmp83_first = true;
                        while(__tmp83_first || !__tmp83Reader.EndOfStream)
                        {
                            __tmp83_first = false;
                            string __tmp83Line = __tmp83Reader.ReadLine();
                            if (__tmp83Line == null)
                            {
                                __tmp83Line = "";
                            }
                            __out.Append(__tmp81Prefix);
                            __out.Append(__tmp83Line);
                        }
                    }
                    string __tmp84Line = "."; //813:50
                    __out.Append(__tmp84Line);
                    StringBuilder __tmp85 = new StringBuilder();
                    __tmp85.Append(op.Name);
                    using(StreamReader __tmp85Reader = new StreamReader(this.__ToStream(__tmp85.ToString())))
                    {
                        bool __tmp85_first = true;
                        while(__tmp85_first || !__tmp85Reader.EndOfStream)
                        {
                            __tmp85_first = false;
                            string __tmp85Line = __tmp85Reader.ReadLine();
                            if (__tmp85Line == null)
                            {
                                __tmp85Line = "";
                            }
                            __out.Append(__tmp85Line);
                            __out.Append(__tmp82Suffix);
                            __out.AppendLine(); //813:60
                        }
                    }
                    __out.Append("     */"); //814:1
                    __out.AppendLine(); //814:8
                    string __tmp86Prefix = "    public "; //815:1
                    string __tmp87Suffix = ") {"; //815:118
                    StringBuilder __tmp88 = new StringBuilder();
                    __tmp88.Append(op.ReturnType.JavaFullPublicName());
                    using(StreamReader __tmp88Reader = new StreamReader(this.__ToStream(__tmp88.ToString())))
                    {
                        bool __tmp88_first = true;
                        while(__tmp88_first || !__tmp88Reader.EndOfStream)
                        {
                            __tmp88_first = false;
                            string __tmp88Line = __tmp88Reader.ReadLine();
                            if (__tmp88Line == null)
                            {
                                __tmp88Line = "";
                            }
                            __out.Append(__tmp86Prefix);
                            __out.Append(__tmp88Line);
                        }
                    }
                    string __tmp89Line = " "; //815:48
                    __out.Append(__tmp89Line);
                    StringBuilder __tmp90 = new StringBuilder();
                    __tmp90.Append(enm.JavaName());
                    using(StreamReader __tmp90Reader = new StreamReader(this.__ToStream(__tmp90.ToString())))
                    {
                        bool __tmp90_first = true;
                        while(__tmp90_first || !__tmp90Reader.EndOfStream)
                        {
                            __tmp90_first = false;
                            string __tmp90Line = __tmp90Reader.ReadLine();
                            if (__tmp90Line == null)
                            {
                                __tmp90Line = "";
                            }
                            __out.Append(__tmp90Line);
                        }
                    }
                    string __tmp91Line = "_"; //815:65
                    __out.Append(__tmp91Line);
                    StringBuilder __tmp92 = new StringBuilder();
                    __tmp92.Append(op.Name.ToCamelCase());
                    using(StreamReader __tmp92Reader = new StreamReader(this.__ToStream(__tmp92.ToString())))
                    {
                        bool __tmp92_first = true;
                        while(__tmp92_first || !__tmp92Reader.EndOfStream)
                        {
                            __tmp92_first = false;
                            string __tmp92Line = __tmp92Reader.ReadLine();
                            if (__tmp92Line == null)
                            {
                                __tmp92Line = "";
                            }
                            __out.Append(__tmp92Line);
                        }
                    }
                    string __tmp93Line = "("; //815:89
                    __out.Append(__tmp93Line);
                    StringBuilder __tmp94 = new StringBuilder();
                    __tmp94.Append(GetImplParameters(enm, op));
                    using(StreamReader __tmp94Reader = new StreamReader(this.__ToStream(__tmp94.ToString())))
                    {
                        bool __tmp94_first = true;
                        while(__tmp94_first || !__tmp94Reader.EndOfStream)
                        {
                            __tmp94_first = false;
                            string __tmp94Line = __tmp94Reader.ReadLine();
                            if (__tmp94Line == null)
                            {
                                __tmp94Line = "";
                            }
                            __out.Append(__tmp94Line);
                            __out.Append(__tmp87Suffix);
                            __out.AppendLine(); //815:121
                        }
                    }
                    __out.Append("        throw new UnsupportedOperationException();"); //816:1
                    __out.AppendLine(); //816:51
                    __out.Append("    }"); //817:1
                    __out.AppendLine(); //817:6
                }
                __out.AppendLine(); //819:1
            }
            __out.Append("}"); //821:1
            __out.AppendLine(); //821:2
            __out.AppendLine(); //822:1
            return __out.ToString();
        }

        public string GenerateFactory(MetaModel model) //825:1
        {
            StringBuilder __out = new StringBuilder();
            string __tmp1Prefix = "package "; //826:1
            string __tmp2Suffix = ";"; //826:37
            StringBuilder __tmp3 = new StringBuilder();
            __tmp3.Append(model.Namespace.JavaName());
            using(StreamReader __tmp3Reader = new StreamReader(this.__ToStream(__tmp3.ToString())))
            {
                bool __tmp3_first = true;
                while(__tmp3_first || !__tmp3Reader.EndOfStream)
                {
                    __tmp3_first = false;
                    string __tmp3Line = __tmp3Reader.ReadLine();
                    if (__tmp3Line == null)
                    {
                        __tmp3Line = "";
                    }
                    __out.Append(__tmp1Prefix);
                    __out.Append(__tmp3Line);
                    __out.Append(__tmp2Suffix);
                    __out.AppendLine(); //826:38
                }
            }
            __out.AppendLine(); //827:1
            __out.Append("/**"); //828:1
            __out.AppendLine(); //828:4
            __out.Append(" * Factory class for creating instances of model elements."); //829:1
            __out.AppendLine(); //829:59
            __out.Append(" */"); //830:1
            __out.AppendLine(); //830:4
            string __tmp4Prefix = "public class "; //831:1
            string __tmp5Suffix = " extends ModelFactory {"; //831:39
            StringBuilder __tmp6 = new StringBuilder();
            __tmp6.Append(model.JavaFactoryName());
            using(StreamReader __tmp6Reader = new StreamReader(this.__ToStream(__tmp6.ToString())))
            {
                bool __tmp6_first = true;
                while(__tmp6_first || !__tmp6Reader.EndOfStream)
                {
                    __tmp6_first = false;
                    string __tmp6Line = __tmp6Reader.ReadLine();
                    if (__tmp6Line == null)
                    {
                        __tmp6Line = "";
                    }
                    __out.Append(__tmp4Prefix);
                    __out.Append(__tmp6Line);
                    __out.Append(__tmp5Suffix);
                    __out.AppendLine(); //831:62
                }
            }
            string __tmp7Prefix = "    private static "; //832:1
            string __tmp8Suffix = "();"; //832:86
            StringBuilder __tmp9 = new StringBuilder();
            __tmp9.Append(model.JavaFactoryName());
            using(StreamReader __tmp9Reader = new StreamReader(this.__ToStream(__tmp9.ToString())))
            {
                bool __tmp9_first = true;
                while(__tmp9_first || !__tmp9Reader.EndOfStream)
                {
                    __tmp9_first = false;
                    string __tmp9Line = __tmp9Reader.ReadLine();
                    if (__tmp9Line == null)
                    {
                        __tmp9Line = "";
                    }
                    __out.Append(__tmp7Prefix);
                    __out.Append(__tmp9Line);
                }
            }
            string __tmp10Line = " instance = new "; //832:45
            __out.Append(__tmp10Line);
            StringBuilder __tmp11 = new StringBuilder();
            __tmp11.Append(model.JavaFactoryName());
            using(StreamReader __tmp11Reader = new StreamReader(this.__ToStream(__tmp11.ToString())))
            {
                bool __tmp11_first = true;
                while(__tmp11_first || !__tmp11Reader.EndOfStream)
                {
                    __tmp11_first = false;
                    string __tmp11Line = __tmp11Reader.ReadLine();
                    if (__tmp11Line == null)
                    {
                        __tmp11Line = "";
                    }
                    __out.Append(__tmp11Line);
                    __out.Append(__tmp8Suffix);
                    __out.AppendLine(); //832:89
                }
            }
            __out.AppendLine(); //833:1
            string __tmp12Prefix = "	private "; //834:1
            string __tmp13Suffix = "()"; //834:35
            StringBuilder __tmp14 = new StringBuilder();
            __tmp14.Append(model.JavaFactoryName());
            using(StreamReader __tmp14Reader = new StreamReader(this.__ToStream(__tmp14.ToString())))
            {
                bool __tmp14_first = true;
                while(__tmp14_first || !__tmp14Reader.EndOfStream)
                {
                    __tmp14_first = false;
                    string __tmp14Line = __tmp14Reader.ReadLine();
                    if (__tmp14Line == null)
                    {
                        __tmp14Line = "";
                    }
                    __out.Append(__tmp12Prefix);
                    __out.Append(__tmp14Line);
                    __out.Append(__tmp13Suffix);
                    __out.AppendLine(); //834:37
                }
            }
            __out.Append("	{"); //835:1
            __out.AppendLine(); //835:3
            __out.Append("	}"); //836:1
            __out.AppendLine(); //836:3
            __out.AppendLine(); //837:1
            __out.Append("    /**"); //838:1
            __out.AppendLine(); //838:8
            __out.Append("     * The singleton instance of the factory."); //839:1
            __out.AppendLine(); //839:46
            __out.Append("     */"); //840:1
            __out.AppendLine(); //840:8
            string __tmp15Prefix = "    public static "; //841:1
            string __tmp16Suffix = " instance() {"; //841:44
            StringBuilder __tmp17 = new StringBuilder();
            __tmp17.Append(model.JavaFactoryName());
            using(StreamReader __tmp17Reader = new StreamReader(this.__ToStream(__tmp17.ToString())))
            {
                bool __tmp17_first = true;
                while(__tmp17_first || !__tmp17Reader.EndOfStream)
                {
                    __tmp17_first = false;
                    string __tmp17Line = __tmp17Reader.ReadLine();
                    if (__tmp17Line == null)
                    {
                        __tmp17Line = "";
                    }
                    __out.Append(__tmp15Prefix);
                    __out.Append(__tmp17Line);
                    __out.Append(__tmp16Suffix);
                    __out.AppendLine(); //841:57
                }
            }
            string __tmp18Prefix = "        return "; //842:1
            string __tmp19Suffix = ".instance;"; //842:41
            StringBuilder __tmp20 = new StringBuilder();
            __tmp20.Append(model.JavaFactoryName());
            using(StreamReader __tmp20Reader = new StreamReader(this.__ToStream(__tmp20.ToString())))
            {
                bool __tmp20_first = true;
                while(__tmp20_first || !__tmp20Reader.EndOfStream)
                {
                    __tmp20_first = false;
                    string __tmp20Line = __tmp20Reader.ReadLine();
                    if (__tmp20Line == null)
                    {
                        __tmp20Line = "";
                    }
                    __out.Append(__tmp18Prefix);
                    __out.Append(__tmp20Line);
                    __out.Append(__tmp19Suffix);
                    __out.AppendLine(); //842:51
                }
            }
            __out.Append("    }"); //843:1
            __out.AppendLine(); //843:6
            var __loop51_results = 
                (from __loop51_var1 in __Enumerate((model).GetEnumerator()) //844:8
                from Namespace in __Enumerate((__loop51_var1.Namespace).GetEnumerator()) //844:15
                from Declarations in __Enumerate((Namespace.Declarations).GetEnumerator()) //844:26
                from cls in __Enumerate((Declarations).GetEnumerator()).OfType<MetaClass>() //844:40
                select new { __loop51_var1 = __loop51_var1, Namespace = Namespace, Declarations = Declarations, cls = cls}
                ).ToList(); //844:3
            int __loop51_iteration = 0;
            foreach (var __tmp21 in __loop51_results)
            {
                ++__loop51_iteration;
                var __loop51_var1 = __tmp21.__loop51_var1;
                var Namespace = __tmp21.Namespace;
                var Declarations = __tmp21.Declarations;
                var cls = __tmp21.cls;
                if (!cls.IsAbstract) //845:4
                {
                    __out.AppendLine(); //846:1
                    __out.Append("    /**"); //847:1
                    __out.AppendLine(); //847:8
                    string __tmp22Prefix = "     * Creates a new instance of "; //848:1
                    string __tmp23Suffix = "."; //848:50
                    StringBuilder __tmp24 = new StringBuilder();
                    __tmp24.Append(cls.JavaName());
                    using(StreamReader __tmp24Reader = new StreamReader(this.__ToStream(__tmp24.ToString())))
                    {
                        bool __tmp24_first = true;
                        while(__tmp24_first || !__tmp24Reader.EndOfStream)
                        {
                            __tmp24_first = false;
                            string __tmp24Line = __tmp24Reader.ReadLine();
                            if (__tmp24Line == null)
                            {
                                __tmp24Line = "";
                            }
                            __out.Append(__tmp22Prefix);
                            __out.Append(__tmp24Line);
                            __out.Append(__tmp23Suffix);
                            __out.AppendLine(); //848:51
                        }
                    }
                    __out.Append("     */"); //849:1
                    __out.AppendLine(); //849:8
                    string __tmp25Prefix = "    public "; //850:1
                    string __tmp26Suffix = "() {"; //850:51
                    StringBuilder __tmp27 = new StringBuilder();
                    __tmp27.Append(cls.JavaName());
                    using(StreamReader __tmp27Reader = new StreamReader(this.__ToStream(__tmp27.ToString())))
                    {
                        bool __tmp27_first = true;
                        while(__tmp27_first || !__tmp27Reader.EndOfStream)
                        {
                            __tmp27_first = false;
                            string __tmp27Line = __tmp27Reader.ReadLine();
                            if (__tmp27Line == null)
                            {
                                __tmp27Line = "";
                            }
                            __out.Append(__tmp25Prefix);
                            __out.Append(__tmp27Line);
                        }
                    }
                    string __tmp28Line = " create"; //850:28
                    __out.Append(__tmp28Line);
                    StringBuilder __tmp29 = new StringBuilder();
                    __tmp29.Append(cls.JavaName());
                    using(StreamReader __tmp29Reader = new StreamReader(this.__ToStream(__tmp29.ToString())))
                    {
                        bool __tmp29_first = true;
                        while(__tmp29_first || !__tmp29Reader.EndOfStream)
                        {
                            __tmp29_first = false;
                            string __tmp29Line = __tmp29Reader.ReadLine();
                            if (__tmp29Line == null)
                            {
                                __tmp29Line = "";
                            }
                            __out.Append(__tmp29Line);
                            __out.Append(__tmp26Suffix);
                            __out.AppendLine(); //850:55
                        }
                    }
                    string __tmp30Prefix = "		return this.create"; //851:1
                    string __tmp31Suffix = "(null);"; //851:37
                    StringBuilder __tmp32 = new StringBuilder();
                    __tmp32.Append(cls.JavaName());
                    using(StreamReader __tmp32Reader = new StreamReader(this.__ToStream(__tmp32.ToString())))
                    {
                        bool __tmp32_first = true;
                        while(__tmp32_first || !__tmp32Reader.EndOfStream)
                        {
                            __tmp32_first = false;
                            string __tmp32Line = __tmp32Reader.ReadLine();
                            if (__tmp32Line == null)
                            {
                                __tmp32Line = "";
                            }
                            __out.Append(__tmp30Prefix);
                            __out.Append(__tmp32Line);
                            __out.Append(__tmp31Suffix);
                            __out.AppendLine(); //851:44
                        }
                    }
                    __out.Append("	}"); //852:1
                    __out.AppendLine(); //852:3
                    __out.Append("    /**"); //854:1
                    __out.AppendLine(); //854:8
                    string __tmp33Prefix = "     * Creates a new instance of "; //855:1
                    string __tmp34Suffix = "."; //855:50
                    StringBuilder __tmp35 = new StringBuilder();
                    __tmp35.Append(cls.JavaName());
                    using(StreamReader __tmp35Reader = new StreamReader(this.__ToStream(__tmp35.ToString())))
                    {
                        bool __tmp35_first = true;
                        while(__tmp35_first || !__tmp35Reader.EndOfStream)
                        {
                            __tmp35_first = false;
                            string __tmp35Line = __tmp35Reader.ReadLine();
                            if (__tmp35Line == null)
                            {
                                __tmp35Line = "";
                            }
                            __out.Append(__tmp33Prefix);
                            __out.Append(__tmp35Line);
                            __out.Append(__tmp34Suffix);
                            __out.AppendLine(); //855:51
                        }
                    }
                    __out.Append("     */"); //856:1
                    __out.AppendLine(); //856:8
                    string __tmp36Prefix = "    public "; //857:1
                    string __tmp37Suffix = "(Iterable<ModelPropertyInitializer> initializers) {"; //857:51
                    StringBuilder __tmp38 = new StringBuilder();
                    __tmp38.Append(cls.JavaName());
                    using(StreamReader __tmp38Reader = new StreamReader(this.__ToStream(__tmp38.ToString())))
                    {
                        bool __tmp38_first = true;
                        while(__tmp38_first || !__tmp38Reader.EndOfStream)
                        {
                            __tmp38_first = false;
                            string __tmp38Line = __tmp38Reader.ReadLine();
                            if (__tmp38Line == null)
                            {
                                __tmp38Line = "";
                            }
                            __out.Append(__tmp36Prefix);
                            __out.Append(__tmp38Line);
                        }
                    }
                    string __tmp39Line = " create"; //857:28
                    __out.Append(__tmp39Line);
                    StringBuilder __tmp40 = new StringBuilder();
                    __tmp40.Append(cls.JavaName());
                    using(StreamReader __tmp40Reader = new StreamReader(this.__ToStream(__tmp40.ToString())))
                    {
                        bool __tmp40_first = true;
                        while(__tmp40_first || !__tmp40Reader.EndOfStream)
                        {
                            __tmp40_first = false;
                            string __tmp40Line = __tmp40Reader.ReadLine();
                            if (__tmp40Line == null)
                            {
                                __tmp40Line = "";
                            }
                            __out.Append(__tmp40Line);
                            __out.Append(__tmp37Suffix);
                            __out.AppendLine(); //857:102
                        }
                    }
                    string __tmp41Prefix = "		"; //858:1
                    string __tmp42Suffix = "Impl();"; //858:53
                    StringBuilder __tmp43 = new StringBuilder();
                    __tmp43.Append(cls.JavaName());
                    using(StreamReader __tmp43Reader = new StreamReader(this.__ToStream(__tmp43.ToString())))
                    {
                        bool __tmp43_first = true;
                        while(__tmp43_first || !__tmp43Reader.EndOfStream)
                        {
                            __tmp43_first = false;
                            string __tmp43Line = __tmp43Reader.ReadLine();
                            if (__tmp43Line == null)
                            {
                                __tmp43Line = "";
                            }
                            __out.Append(__tmp41Prefix);
                            __out.Append(__tmp43Line);
                        }
                    }
                    string __tmp44Line = " result = new "; //858:19
                    __out.Append(__tmp44Line);
                    StringBuilder __tmp45 = new StringBuilder();
                    __tmp45.Append(cls.JavaFullName());
                    using(StreamReader __tmp45Reader = new StreamReader(this.__ToStream(__tmp45.ToString())))
                    {
                        bool __tmp45_first = true;
                        while(__tmp45_first || !__tmp45Reader.EndOfStream)
                        {
                            __tmp45_first = false;
                            string __tmp45Line = __tmp45Reader.ReadLine();
                            if (__tmp45Line == null)
                            {
                                __tmp45Line = "";
                            }
                            __out.Append(__tmp45Line);
                            __out.Append(__tmp42Suffix);
                            __out.AppendLine(); //858:60
                        }
                    }
                    __out.Append("		if (initializers != null) {"); //859:1
                    __out.AppendLine(); //859:30
                    __out.Append("			this.init((ModelObject)result, initializers);"); //860:1
                    __out.AppendLine(); //860:49
                    __out.Append("		}"); //861:1
                    __out.AppendLine(); //861:4
                    __out.Append("		return result;"); //862:1
                    __out.AppendLine(); //862:17
                    __out.Append("	}"); //863:1
                    __out.AppendLine(); //863:3
                }
            }
            __out.Append("}"); //866:1
            __out.AppendLine(); //866:2
            __out.AppendLine(); //867:1
            return __out.ToString();
        }

    }
}

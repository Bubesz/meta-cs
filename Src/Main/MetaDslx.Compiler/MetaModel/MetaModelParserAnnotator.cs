using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using MetaDslx.Core;

namespace MetaDslx.Compiler
{
    internal class MetaModelParserAnnotator : MetaModelParserBaseVisitor<object>
    {
        private MetaModelLexerAnnotator lexerAnnotator = new MetaModelLexerAnnotator();
        private List<object> grammarAnnotations = new List<object>();
        private Dictionary<Type, List<object>> ruleAnnotations = new Dictionary<Type, List<object>>();
        private Dictionary<object, List<object>> treeAnnotations = new Dictionary<object, List<object>>();
        
        public List<object> ParserAnnotations { get { return this.grammarAnnotations; } }
        public List<object> LexerAnnotations { get { return this.lexerAnnotator.LexerAnnotations; } }
        public Dictionary<int, List<object>> TokenAnnotations { get { return this.lexerAnnotator.TokenAnnotations; } }
        public Dictionary<int, List<object>> ModeAnnotations { get { return this.lexerAnnotator.ModeAnnotations; } }
        public Dictionary<Type, List<object>> RuleAnnotations { get { return this.ruleAnnotations; } }
        public Dictionary<object, List<object>> TreeAnnotations { get { return this.treeAnnotations; } }
        
        private QualifiedNameAnnotation qualifiedName_QualifiedName;
        private NameCtrAnnotation namespaceDeclaration_NameCtr;
        private PropertyAnnotation namespaceDeclaration_QualifiedName_Property;
        private NameDefAnnotation namespaceDeclaration_QualifiedName_NameDef;
        private PropertyAnnotation namespaceDeclaration_StringLiteral_Property;
        private PropertyAnnotation namespaceDeclaration_MetamodelDeclaration_Property;
        private TypeCtrAnnotation metamodelDeclaration_TypeCtr;
        private PropertyAnnotation metamodelDeclaration_Identifier_Property;
        private TypeDefAnnotation metamodelDeclaration_Identifier_TypeDef;
        private PropertyAnnotation metamodelDeclaration_Declaration_Property;
        private TypeCtrAnnotation enumDeclaration_TypeCtr;
        private PropertyAnnotation enumDeclaration_Identifier_Property;
        private TypeDefAnnotation enumDeclaration_Identifier_TypeDef;
        private PropertyAnnotation enumDeclaration_EnumValues_Property;
        private NameCtrAnnotation enumValue_NameCtr;
        private PropertyAnnotation enumValue_Identifier_Property;
        private NameDefAnnotation enumValue_Identifier_NameDef;
        private PropertyAnnotation enumMemberDeclaration_OperationDeclaration_Property;
        private TypeCtrAnnotation classDeclaration_TypeCtr;
        private PropertyAnnotation classDeclaration_KAbstract_Property;
        private PropertyAnnotation classDeclaration_Identifier_Property;
        private TypeDefAnnotation classDeclaration_Identifier_TypeDef;
        private PropertyAnnotation classDeclaration_ClassAncestors_Property;
        private TypeUseAnnotation classAncestor_QualifiedName_TypeUse;
        private PropertyAnnotation classMemberDeclaration_FieldDeclaration_Property;
        private PropertyAnnotation classMemberDeclaration_OperationDeclaration_Property;
        private NameCtrAnnotation fieldDeclaration_NameCtr;
        private PropertyAnnotation fieldDeclaration_FieldModifier_Property;
        private PropertyAnnotation fieldDeclaration_Identifier_Property;
        private NameDefAnnotation fieldDeclaration_Identifier_NameDef;
        private TypeUseAnnotation returnType_TypeUse;
        private TypeUseAnnotation typeReference_TypeUse;
        private TypeUseAnnotation simpleType_TypeUse;
        private NameAnnotation objectType_Name;
        private TypeUseAnnotation objectType_TypeUse;
        private TypeCtrAnnotation objectType_TypeCtr;
        private PreDefSymbolAnnotation objectType_KObject_PreDefSymbol;
        private PreDefSymbolAnnotation objectType_KString_PreDefSymbol;
        private NameAnnotation primitiveType_Name;
        private TypeUseAnnotation primitiveType_TypeUse;
        private TypeCtrAnnotation primitiveType_TypeCtr;
        private PreDefSymbolAnnotation primitiveType_KInt_PreDefSymbol;
        private PreDefSymbolAnnotation primitiveType_KLong_PreDefSymbol;
        private PreDefSymbolAnnotation primitiveType_KFloat_PreDefSymbol;
        private PreDefSymbolAnnotation primitiveType_KDouble_PreDefSymbol;
        private PreDefSymbolAnnotation primitiveType_KByte_PreDefSymbol;
        private PreDefSymbolAnnotation primitiveType_KBool_PreDefSymbol;
        private NameAnnotation voidType_Name;
        private TypeUseAnnotation voidType_TypeUse;
        private TypeCtrAnnotation voidType_TypeCtr;
        private PreDefSymbolAnnotation voidType_KVoid_PreDefSymbol;
        private TypeUseAnnotation nullableType_TypeUse;
        private TypeCtrAnnotation nullableType_TypeCtr;
        private PropertyAnnotation nullableType_PrimitiveType_Property;
        private TypeUseAnnotation collectionType_TypeUse;
        private TypeCtrAnnotation collectionType_TypeCtr;
        private PropertyAnnotation collectionType_CollectionKind_Property;
        private PropertyAnnotation collectionType_SimpleType_Property;
        private NameCtrAnnotation operationDeclaration_NameCtr;
        private TypeCtrAnnotation operationDeclaration_TypeCtr;
        private PropertyAnnotation operationDeclaration_ReturnType_Property;
        private PropertyAnnotation operationDeclaration_Identifier_Property;
        private TypeDefAnnotation operationDeclaration_Identifier_TypeDef;
        private NameDefAnnotation operationDeclaration_Identifier_NameDef;
        private PropertyAnnotation operationDeclaration_ParameterList_Property;
        private NameCtrAnnotation parameter_NameCtr;
        private PropertyAnnotation parameter_TypeReference_Property;
        private NameDefAnnotation parameter_Identifier_NameDef;
        private NameUseAnnotation associationDeclaration_Source_NameUse;
        private NameUseAnnotation associationDeclaration_Target_NameUse;
        private NameAnnotation identifier_Name;
        private IdentifierAnnotation identifier_Identifier;
        
        public MetaModelParserAnnotator()
        {
            List<object> annotList = null;
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.QualifiedNameContext), annotList);
            this.qualifiedName_QualifiedName = new QualifiedNameAnnotation();
            annotList.Add(this.qualifiedName_QualifiedName);
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.NamespaceDeclarationContext), annotList);
            this.namespaceDeclaration_NameCtr = new NameCtrAnnotation();
            this.namespaceDeclaration_NameCtr.SymbolType = typeof(MetaNamespace);
            this.namespaceDeclaration_NameCtr.Scope = true;
            this.namespaceDeclaration_NameCtr.Merge = true;
            annotList.Add(this.namespaceDeclaration_NameCtr);
            this.namespaceDeclaration_QualifiedName_Property = new PropertyAnnotation();
            this.namespaceDeclaration_QualifiedName_Property.Name = "Name";
            this.namespaceDeclaration_QualifiedName_NameDef = new NameDefAnnotation();
            this.namespaceDeclaration_StringLiteral_Property = new PropertyAnnotation();
            this.namespaceDeclaration_StringLiteral_Property.Name = "Uri";
            this.namespaceDeclaration_MetamodelDeclaration_Property = new PropertyAnnotation();
            this.namespaceDeclaration_MetamodelDeclaration_Property.Name = "Models";
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.MetamodelDeclarationContext), annotList);
            this.metamodelDeclaration_TypeCtr = new TypeCtrAnnotation();
            this.metamodelDeclaration_TypeCtr.SymbolType = typeof(MetaModel);
            annotList.Add(this.metamodelDeclaration_TypeCtr);
            this.metamodelDeclaration_Identifier_Property = new PropertyAnnotation();
            this.metamodelDeclaration_Identifier_Property.Name = "Name";
            this.metamodelDeclaration_Identifier_TypeDef = new TypeDefAnnotation();
            this.metamodelDeclaration_Declaration_Property = new PropertyAnnotation();
            this.metamodelDeclaration_Declaration_Property.Name = "Types";
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.EnumDeclarationContext), annotList);
            this.enumDeclaration_TypeCtr = new TypeCtrAnnotation();
            this.enumDeclaration_TypeCtr.SymbolType = typeof(MetaEnum);
            annotList.Add(this.enumDeclaration_TypeCtr);
            this.enumDeclaration_Identifier_Property = new PropertyAnnotation();
            this.enumDeclaration_Identifier_Property.Name = "Name";
            this.enumDeclaration_Identifier_TypeDef = new TypeDefAnnotation();
            this.enumDeclaration_EnumValues_Property = new PropertyAnnotation();
            this.enumDeclaration_EnumValues_Property.Name = "EnumLiterals";
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.EnumValueContext), annotList);
            this.enumValue_NameCtr = new NameCtrAnnotation();
            this.enumValue_NameCtr.SymbolType = typeof(MetaEnumLiteral);
            annotList.Add(this.enumValue_NameCtr);
            this.enumValue_Identifier_Property = new PropertyAnnotation();
            this.enumValue_Identifier_Property.Name = "Name";
            this.enumValue_Identifier_NameDef = new NameDefAnnotation();
            
            this.enumMemberDeclaration_OperationDeclaration_Property = new PropertyAnnotation();
            this.enumMemberDeclaration_OperationDeclaration_Property.Name = "Operations";
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.ClassDeclarationContext), annotList);
            this.classDeclaration_TypeCtr = new TypeCtrAnnotation();
            this.classDeclaration_TypeCtr.SymbolType = typeof(MetaClass);
            annotList.Add(this.classDeclaration_TypeCtr);
            this.classDeclaration_KAbstract_Property = new PropertyAnnotation();
            this.classDeclaration_KAbstract_Property.Name = "IsAbstract";
            this.classDeclaration_Identifier_Property = new PropertyAnnotation();
            this.classDeclaration_Identifier_Property.Name = "Name";
            this.classDeclaration_Identifier_TypeDef = new TypeDefAnnotation();
            this.classDeclaration_ClassAncestors_Property = new PropertyAnnotation();
            this.classDeclaration_ClassAncestors_Property.Name = "SuperClasses";
            
            this.classAncestor_QualifiedName_TypeUse = new TypeUseAnnotation();
            this.classAncestor_QualifiedName_TypeUse.SymbolTypes.Add(typeof(MetaClass));
            
            this.classMemberDeclaration_FieldDeclaration_Property = new PropertyAnnotation();
            this.classMemberDeclaration_FieldDeclaration_Property.Name = "Properties";
            this.classMemberDeclaration_OperationDeclaration_Property = new PropertyAnnotation();
            this.classMemberDeclaration_OperationDeclaration_Property.Name = "Operations";
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.FieldDeclarationContext), annotList);
            this.fieldDeclaration_NameCtr = new NameCtrAnnotation();
            this.fieldDeclaration_NameCtr.SymbolType = typeof(MetaProperty);
            annotList.Add(this.fieldDeclaration_NameCtr);
            this.fieldDeclaration_FieldModifier_Property = new PropertyAnnotation();
            this.fieldDeclaration_FieldModifier_Property.Name = "Kind";
            this.fieldDeclaration_Identifier_Property = new PropertyAnnotation();
            this.fieldDeclaration_Identifier_Property.Name = "Name";
            this.fieldDeclaration_Identifier_NameDef = new NameDefAnnotation();
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.ReturnTypeContext), annotList);
            this.returnType_TypeUse = new TypeUseAnnotation();
            annotList.Add(this.returnType_TypeUse);
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.TypeReferenceContext), annotList);
            this.typeReference_TypeUse = new TypeUseAnnotation();
            annotList.Add(this.typeReference_TypeUse);
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.SimpleTypeContext), annotList);
            this.simpleType_TypeUse = new TypeUseAnnotation();
            annotList.Add(this.simpleType_TypeUse);
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.ObjectTypeContext), annotList);
            this.objectType_Name = new NameAnnotation();
            annotList.Add(this.objectType_Name);
            this.objectType_TypeUse = new TypeUseAnnotation();
            annotList.Add(this.objectType_TypeUse);
            this.objectType_TypeCtr = new TypeCtrAnnotation();
            this.objectType_TypeCtr.SymbolType = typeof(MetaPrimitiveType);
            this.objectType_TypeCtr.Scope = false;
            this.objectType_TypeCtr.Merge = true;
            annotList.Add(this.objectType_TypeCtr);
            this.objectType_KObject_PreDefSymbol = new PreDefSymbolAnnotation();
            this.objectType_KObject_PreDefSymbol.Value = MetaBuiltInType.Object;
            this.objectType_KString_PreDefSymbol = new PreDefSymbolAnnotation();
            this.objectType_KString_PreDefSymbol.Value = MetaBuiltInType.String;
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.PrimitiveTypeContext), annotList);
            this.primitiveType_Name = new NameAnnotation();
            annotList.Add(this.primitiveType_Name);
            this.primitiveType_TypeUse = new TypeUseAnnotation();
            annotList.Add(this.primitiveType_TypeUse);
            this.primitiveType_TypeCtr = new TypeCtrAnnotation();
            this.primitiveType_TypeCtr.SymbolType = typeof(MetaPrimitiveType);
            this.primitiveType_TypeCtr.Scope = false;
            this.primitiveType_TypeCtr.Merge = true;
            annotList.Add(this.primitiveType_TypeCtr);
            this.primitiveType_KInt_PreDefSymbol = new PreDefSymbolAnnotation();
            this.primitiveType_KInt_PreDefSymbol.Value = MetaBuiltInType.Int;
            this.primitiveType_KLong_PreDefSymbol = new PreDefSymbolAnnotation();
            this.primitiveType_KLong_PreDefSymbol.Value = MetaBuiltInType.Long;
            this.primitiveType_KFloat_PreDefSymbol = new PreDefSymbolAnnotation();
            this.primitiveType_KFloat_PreDefSymbol.Value = MetaBuiltInType.Float;
            this.primitiveType_KDouble_PreDefSymbol = new PreDefSymbolAnnotation();
            this.primitiveType_KDouble_PreDefSymbol.Value = MetaBuiltInType.Double;
            this.primitiveType_KByte_PreDefSymbol = new PreDefSymbolAnnotation();
            this.primitiveType_KByte_PreDefSymbol.Value = MetaBuiltInType.Byte;
            this.primitiveType_KBool_PreDefSymbol = new PreDefSymbolAnnotation();
            this.primitiveType_KBool_PreDefSymbol.Value = MetaBuiltInType.Bool;
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.VoidTypeContext), annotList);
            this.voidType_Name = new NameAnnotation();
            annotList.Add(this.voidType_Name);
            this.voidType_TypeUse = new TypeUseAnnotation();
            annotList.Add(this.voidType_TypeUse);
            this.voidType_TypeCtr = new TypeCtrAnnotation();
            this.voidType_TypeCtr.SymbolType = typeof(MetaPrimitiveType);
            this.voidType_TypeCtr.Scope = false;
            this.voidType_TypeCtr.Merge = true;
            annotList.Add(this.voidType_TypeCtr);
            this.voidType_KVoid_PreDefSymbol = new PreDefSymbolAnnotation();
            this.voidType_KVoid_PreDefSymbol.Value = MetaBuiltInType.Void;
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.NullableTypeContext), annotList);
            this.nullableType_TypeUse = new TypeUseAnnotation();
            annotList.Add(this.nullableType_TypeUse);
            this.nullableType_TypeCtr = new TypeCtrAnnotation();
            this.nullableType_TypeCtr.SymbolType = typeof(MetaNullableType);
            this.nullableType_TypeCtr.Scope = false;
            annotList.Add(this.nullableType_TypeCtr);
            this.nullableType_PrimitiveType_Property = new PropertyAnnotation();
            this.nullableType_PrimitiveType_Property.Name = "InnerType";
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.CollectionTypeContext), annotList);
            this.collectionType_TypeUse = new TypeUseAnnotation();
            annotList.Add(this.collectionType_TypeUse);
            this.collectionType_TypeCtr = new TypeCtrAnnotation();
            this.collectionType_TypeCtr.SymbolType = typeof(MetaCollectionType);
            this.collectionType_TypeCtr.Scope = false;
            annotList.Add(this.collectionType_TypeCtr);
            this.collectionType_CollectionKind_Property = new PropertyAnnotation();
            this.collectionType_CollectionKind_Property.Name = "Kind";
            this.collectionType_SimpleType_Property = new PropertyAnnotation();
            this.collectionType_SimpleType_Property.Name = "InnerType";
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.OperationDeclarationContext), annotList);
            this.operationDeclaration_NameCtr = new NameCtrAnnotation();
            this.operationDeclaration_NameCtr.SymbolType = typeof(MetaOperation);
            annotList.Add(this.operationDeclaration_NameCtr);
            this.operationDeclaration_TypeCtr = new TypeCtrAnnotation();
            this.operationDeclaration_TypeCtr.SymbolType = typeof(MetaOperation);
            this.operationDeclaration_TypeCtr.Scope = false;
            annotList.Add(this.operationDeclaration_TypeCtr);
            this.operationDeclaration_ReturnType_Property = new PropertyAnnotation();
            this.operationDeclaration_ReturnType_Property.Name = "ReturnType";
            this.operationDeclaration_Identifier_Property = new PropertyAnnotation();
            this.operationDeclaration_Identifier_Property.Name = "Name";
            this.operationDeclaration_Identifier_TypeDef = new TypeDefAnnotation();
            this.operationDeclaration_Identifier_NameDef = new NameDefAnnotation();
            this.operationDeclaration_ParameterList_Property = new PropertyAnnotation();
            this.operationDeclaration_ParameterList_Property.Name = "Parameters";
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.ParameterContext), annotList);
            this.parameter_NameCtr = new NameCtrAnnotation();
            this.parameter_NameCtr.SymbolType = typeof(MetaParameter);
            annotList.Add(this.parameter_NameCtr);
            this.parameter_TypeReference_Property = new PropertyAnnotation();
            this.parameter_TypeReference_Property.Name = "Type";
            this.parameter_Identifier_NameDef = new NameDefAnnotation();
            
            this.associationDeclaration_Source_NameUse = new NameUseAnnotation();
            this.associationDeclaration_Source_NameUse.SymbolTypes.Add(typeof(MetaProperty));
            this.associationDeclaration_Target_NameUse = new NameUseAnnotation();
            this.associationDeclaration_Target_NameUse.SymbolTypes.Add(typeof(MetaProperty));
            
            annotList = new List<object>();
            this.ruleAnnotations.Add(typeof(MetaModelParser.IdentifierContext), annotList);
            this.identifier_Name = new NameAnnotation();
            annotList.Add(this.identifier_Name);
            this.identifier_Identifier = new IdentifierAnnotation();
            annotList.Add(this.identifier_Identifier);
        }
        
        public override object VisitTerminal(ITerminalNode node)
        {
            return this.lexerAnnotator.VisitTerminal(node, treeAnnotations);
        }
        
        public override object VisitMain(MetaModelParser.MainContext context)
        {
            return base.VisitMain(context);
        }
        
        public override object VisitQualifiedName(MetaModelParser.QualifiedNameContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.qualifiedName_QualifiedName);
            return base.VisitQualifiedName(context);
        }
        
        public override object VisitIdentifierList(MetaModelParser.IdentifierListContext context)
        {
            return base.VisitIdentifierList(context);
        }
        
        public override object VisitQualifiedNameList(MetaModelParser.QualifiedNameListContext context)
        {
            return base.VisitQualifiedNameList(context);
        }
        
        public override object VisitNamespaceDeclaration(MetaModelParser.NamespaceDeclarationContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.namespaceDeclaration_NameCtr);
            List<object> elemAnnotList = null;
            if (context.qualifiedName() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.qualifiedName(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.qualifiedName(), elemAnnotList);
                }
                elemAnnotList.Add(this.namespaceDeclaration_QualifiedName_Property);
                ValueAnnotation __tmp1 = new ValueAnnotation();
                __tmp1.Value = context.GetText();
                elemAnnotList.Add(__tmp1);
                elemAnnotList.Add(this.namespaceDeclaration_QualifiedName_NameDef);
            }
            if (context.stringLiteral() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.stringLiteral(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.stringLiteral(), elemAnnotList);
                }
                elemAnnotList.Add(this.namespaceDeclaration_StringLiteral_Property);
                ValueAnnotation __tmp2 = new ValueAnnotation();
                __tmp2.Value = context.GetText();
                elemAnnotList.Add(__tmp2);
            }
            if (context.metamodelDeclaration() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.metamodelDeclaration(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.metamodelDeclaration(), elemAnnotList);
                }
                elemAnnotList.Add(this.namespaceDeclaration_MetamodelDeclaration_Property);
            }
            return base.VisitNamespaceDeclaration(context);
        }
        
        public override object VisitMetamodelDeclaration(MetaModelParser.MetamodelDeclarationContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.metamodelDeclaration_TypeCtr);
            List<object> elemAnnotList = null;
            if (context.identifier() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.identifier(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.identifier(), elemAnnotList);
                }
                elemAnnotList.Add(this.metamodelDeclaration_Identifier_Property);
                ValueAnnotation __tmp3 = new ValueAnnotation();
                __tmp3.Value = context.GetText();
                elemAnnotList.Add(__tmp3);
                elemAnnotList.Add(this.metamodelDeclaration_Identifier_TypeDef);
            }
            if (context.declaration() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.declaration(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.declaration(), elemAnnotList);
                }
                elemAnnotList.Add(this.metamodelDeclaration_Declaration_Property);
            }
            return base.VisitMetamodelDeclaration(context);
        }
        
        public override object VisitDeclaration(MetaModelParser.DeclarationContext context)
        {
            return base.VisitDeclaration(context);
        }
        
        public override object VisitEnumDeclaration(MetaModelParser.EnumDeclarationContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.enumDeclaration_TypeCtr);
            List<object> elemAnnotList = null;
            if (context.identifier() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.identifier(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.identifier(), elemAnnotList);
                }
                elemAnnotList.Add(this.enumDeclaration_Identifier_Property);
                ValueAnnotation __tmp4 = new ValueAnnotation();
                __tmp4.Value = context.GetText();
                elemAnnotList.Add(__tmp4);
                elemAnnotList.Add(this.enumDeclaration_Identifier_TypeDef);
            }
            if (context.enumValues() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.enumValues(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.enumValues(), elemAnnotList);
                }
                elemAnnotList.Add(this.enumDeclaration_EnumValues_Property);
            }
            return base.VisitEnumDeclaration(context);
        }
        
        public override object VisitEnumValues(MetaModelParser.EnumValuesContext context)
        {
            return base.VisitEnumValues(context);
        }
        
        public override object VisitEnumValue(MetaModelParser.EnumValueContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.enumValue_NameCtr);
            List<object> elemAnnotList = null;
            if (context.identifier() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.identifier(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.identifier(), elemAnnotList);
                }
                elemAnnotList.Add(this.enumValue_Identifier_Property);
                ValueAnnotation __tmp5 = new ValueAnnotation();
                __tmp5.Value = context.GetText();
                elemAnnotList.Add(__tmp5);
                elemAnnotList.Add(this.enumValue_Identifier_NameDef);
            }
            return base.VisitEnumValue(context);
        }
        
        public override object VisitEnumMemberDeclaration(MetaModelParser.EnumMemberDeclarationContext context)
        {
            List<object> elemAnnotList = null;
            if (context.operationDeclaration() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.operationDeclaration(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.operationDeclaration(), elemAnnotList);
                }
                elemAnnotList.Add(this.enumMemberDeclaration_OperationDeclaration_Property);
            }
            return base.VisitEnumMemberDeclaration(context);
        }
        
        public override object VisitClassDeclaration(MetaModelParser.ClassDeclarationContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.classDeclaration_TypeCtr);
            List<object> elemAnnotList = null;
            if (context.KAbstract() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KAbstract(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KAbstract(), elemAnnotList);
                }
                elemAnnotList.Add(this.classDeclaration_KAbstract_Property);
                ValueAnnotation __tmp6 = new ValueAnnotation();
                __tmp6.Value = true;
                elemAnnotList.Add(__tmp6);
            }
            if (context.identifier() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.identifier(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.identifier(), elemAnnotList);
                }
                elemAnnotList.Add(this.classDeclaration_Identifier_Property);
                ValueAnnotation __tmp7 = new ValueAnnotation();
                __tmp7.Value = context.GetText();
                elemAnnotList.Add(__tmp7);
                elemAnnotList.Add(this.classDeclaration_Identifier_TypeDef);
            }
            if (context.classAncestors() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.classAncestors(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.classAncestors(), elemAnnotList);
                }
                elemAnnotList.Add(this.classDeclaration_ClassAncestors_Property);
            }
            return base.VisitClassDeclaration(context);
        }
        
        public override object VisitClassAncestors(MetaModelParser.ClassAncestorsContext context)
        {
            return base.VisitClassAncestors(context);
        }
        
        public override object VisitClassAncestor(MetaModelParser.ClassAncestorContext context)
        {
            List<object> elemAnnotList = null;
            if (context.qualifiedName() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.qualifiedName(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.qualifiedName(), elemAnnotList);
                }
                elemAnnotList.Add(this.classAncestor_QualifiedName_TypeUse);
            }
            return base.VisitClassAncestor(context);
        }
        
        public override object VisitClassMemberDeclaration(MetaModelParser.ClassMemberDeclarationContext context)
        {
            List<object> elemAnnotList = null;
            if (context.fieldDeclaration() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.fieldDeclaration(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.fieldDeclaration(), elemAnnotList);
                }
                elemAnnotList.Add(this.classMemberDeclaration_FieldDeclaration_Property);
            }
            if (context.operationDeclaration() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.operationDeclaration(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.operationDeclaration(), elemAnnotList);
                }
                elemAnnotList.Add(this.classMemberDeclaration_OperationDeclaration_Property);
            }
            return base.VisitClassMemberDeclaration(context);
        }
        
        public override object VisitFieldDeclaration(MetaModelParser.FieldDeclarationContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.fieldDeclaration_NameCtr);
            List<object> elemAnnotList = null;
            if (context.fieldModifier() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.fieldModifier(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.fieldModifier(), elemAnnotList);
                }
                elemAnnotList.Add(this.fieldDeclaration_FieldModifier_Property);
            }
            if (context.identifier() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.identifier(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.identifier(), elemAnnotList);
                }
                elemAnnotList.Add(this.fieldDeclaration_Identifier_Property);
                ValueAnnotation __tmp8 = new ValueAnnotation();
                __tmp8.Value = context.GetText();
                elemAnnotList.Add(__tmp8);
                elemAnnotList.Add(this.fieldDeclaration_Identifier_NameDef);
            }
            return base.VisitFieldDeclaration(context);
        }
        
        public override object VisitFieldModifier(MetaModelParser.FieldModifierContext context)
        {
            List<object> elemAnnotList = null;
            if (context.KContainment() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KContainment(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KContainment(), elemAnnotList);
                }
                ValueAnnotation __tmp9 = new ValueAnnotation();
                __tmp9.Value = MetaPropertyKind.Containment;
                elemAnnotList.Add(__tmp9);
            }
            if (context.KReadonly() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KReadonly(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KReadonly(), elemAnnotList);
                }
                ValueAnnotation __tmp10 = new ValueAnnotation();
                __tmp10.Value = MetaPropertyKind.Readonly;
                elemAnnotList.Add(__tmp10);
            }
            if (context.KLazy() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KLazy(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KLazy(), elemAnnotList);
                }
                ValueAnnotation __tmp11 = new ValueAnnotation();
                __tmp11.Value = MetaPropertyKind.Lazy;
                elemAnnotList.Add(__tmp11);
            }
            if (context.KDerived() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KDerived(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KDerived(), elemAnnotList);
                }
                ValueAnnotation __tmp12 = new ValueAnnotation();
                __tmp12.Value = MetaPropertyKind.Derived;
                elemAnnotList.Add(__tmp12);
            }
            return base.VisitFieldModifier(context);
        }
        
        public override object VisitConstDeclaration(MetaModelParser.ConstDeclarationContext context)
        {
            return base.VisitConstDeclaration(context);
        }
        
        public override object VisitReturnType(MetaModelParser.ReturnTypeContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.returnType_TypeUse);
            return base.VisitReturnType(context);
        }
        
        public override object VisitTypeReference(MetaModelParser.TypeReferenceContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.typeReference_TypeUse);
            return base.VisitTypeReference(context);
        }
        
        public override object VisitSimpleType(MetaModelParser.SimpleTypeContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.simpleType_TypeUse);
            return base.VisitSimpleType(context);
        }
        
        public override object VisitObjectType(MetaModelParser.ObjectTypeContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.objectType_Name);
            treeAnnotList.Add(this.objectType_TypeUse);
            treeAnnotList.Add(this.objectType_TypeCtr);
            List<object> elemAnnotList = null;
            if (context.KObject() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KObject(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KObject(), elemAnnotList);
                }
                elemAnnotList.Add(this.objectType_KObject_PreDefSymbol);
            }
            if (context.KString() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KString(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KString(), elemAnnotList);
                }
                elemAnnotList.Add(this.objectType_KString_PreDefSymbol);
            }
            return base.VisitObjectType(context);
        }
        
        public override object VisitPrimitiveType(MetaModelParser.PrimitiveTypeContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.primitiveType_Name);
            treeAnnotList.Add(this.primitiveType_TypeUse);
            treeAnnotList.Add(this.primitiveType_TypeCtr);
            List<object> elemAnnotList = null;
            if (context.KInt() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KInt(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KInt(), elemAnnotList);
                }
                elemAnnotList.Add(this.primitiveType_KInt_PreDefSymbol);
            }
            if (context.KLong() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KLong(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KLong(), elemAnnotList);
                }
                elemAnnotList.Add(this.primitiveType_KLong_PreDefSymbol);
            }
            if (context.KFloat() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KFloat(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KFloat(), elemAnnotList);
                }
                elemAnnotList.Add(this.primitiveType_KFloat_PreDefSymbol);
            }
            if (context.KDouble() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KDouble(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KDouble(), elemAnnotList);
                }
                elemAnnotList.Add(this.primitiveType_KDouble_PreDefSymbol);
            }
            if (context.KByte() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KByte(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KByte(), elemAnnotList);
                }
                elemAnnotList.Add(this.primitiveType_KByte_PreDefSymbol);
            }
            if (context.KBool() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KBool(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KBool(), elemAnnotList);
                }
                elemAnnotList.Add(this.primitiveType_KBool_PreDefSymbol);
            }
            return base.VisitPrimitiveType(context);
        }
        
        public override object VisitVoidType(MetaModelParser.VoidTypeContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.voidType_Name);
            treeAnnotList.Add(this.voidType_TypeUse);
            treeAnnotList.Add(this.voidType_TypeCtr);
            List<object> elemAnnotList = null;
            if (context.KVoid() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KVoid(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KVoid(), elemAnnotList);
                }
                elemAnnotList.Add(this.voidType_KVoid_PreDefSymbol);
            }
            return base.VisitVoidType(context);
        }
        
        public override object VisitNullableType(MetaModelParser.NullableTypeContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.nullableType_TypeUse);
            treeAnnotList.Add(this.nullableType_TypeCtr);
            List<object> elemAnnotList = null;
            if (context.primitiveType() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.primitiveType(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.primitiveType(), elemAnnotList);
                }
                elemAnnotList.Add(this.nullableType_PrimitiveType_Property);
            }
            return base.VisitNullableType(context);
        }
        
        public override object VisitCollectionType(MetaModelParser.CollectionTypeContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.collectionType_TypeUse);
            treeAnnotList.Add(this.collectionType_TypeCtr);
            List<object> elemAnnotList = null;
            if (context.collectionKind() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.collectionKind(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.collectionKind(), elemAnnotList);
                }
                elemAnnotList.Add(this.collectionType_CollectionKind_Property);
            }
            if (context.simpleType() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.simpleType(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.simpleType(), elemAnnotList);
                }
                elemAnnotList.Add(this.collectionType_SimpleType_Property);
            }
            return base.VisitCollectionType(context);
        }
        
        public override object VisitCollectionKind(MetaModelParser.CollectionKindContext context)
        {
            List<object> elemAnnotList = null;
            if (context.KSet() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KSet(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KSet(), elemAnnotList);
                }
                ValueAnnotation __tmp13 = new ValueAnnotation();
                __tmp13.Value = MetaCollectionKind.Set;
                elemAnnotList.Add(__tmp13);
            }
            if (context.KList() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.KList(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.KList(), elemAnnotList);
                }
                ValueAnnotation __tmp14 = new ValueAnnotation();
                __tmp14.Value = MetaCollectionKind.List;
                elemAnnotList.Add(__tmp14);
            }
            return base.VisitCollectionKind(context);
        }
        
        public override object VisitOperationDeclaration(MetaModelParser.OperationDeclarationContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.operationDeclaration_NameCtr);
            treeAnnotList.Add(this.operationDeclaration_TypeCtr);
            List<object> elemAnnotList = null;
            if (context.returnType() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.returnType(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.returnType(), elemAnnotList);
                }
                elemAnnotList.Add(this.operationDeclaration_ReturnType_Property);
            }
            if (context.identifier() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.identifier(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.identifier(), elemAnnotList);
                }
                elemAnnotList.Add(this.operationDeclaration_Identifier_Property);
                ValueAnnotation __tmp15 = new ValueAnnotation();
                __tmp15.Value = context.GetText();
                elemAnnotList.Add(__tmp15);
                elemAnnotList.Add(this.operationDeclaration_Identifier_TypeDef);
                elemAnnotList.Add(this.operationDeclaration_Identifier_NameDef);
            }
            if (context.parameterList() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.parameterList(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.parameterList(), elemAnnotList);
                }
                elemAnnotList.Add(this.operationDeclaration_ParameterList_Property);
            }
            return base.VisitOperationDeclaration(context);
        }
        
        public override object VisitParameterList(MetaModelParser.ParameterListContext context)
        {
            return base.VisitParameterList(context);
        }
        
        public override object VisitParameter(MetaModelParser.ParameterContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.parameter_NameCtr);
            List<object> elemAnnotList = null;
            if (context.typeReference() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.typeReference(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.typeReference(), elemAnnotList);
                }
                elemAnnotList.Add(this.parameter_TypeReference_Property);
            }
            if (context.identifier() != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.identifier(), out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.identifier(), elemAnnotList);
                }
                elemAnnotList.Add(this.parameter_Identifier_NameDef);
            }
            return base.VisitParameter(context);
        }
        
        public override object VisitAssociationDeclaration(MetaModelParser.AssociationDeclarationContext context)
        {
            List<object> elemAnnotList = null;
            if (context.source != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.source, out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.source, elemAnnotList);
                }
                elemAnnotList.Add(this.associationDeclaration_Source_NameUse);
            }
            if (context.target != null)
            {
                if (!this.treeAnnotations.TryGetValue(context.target, out elemAnnotList))
                {
                    elemAnnotList = new List<object>();
                    this.treeAnnotations.Add(context.target, elemAnnotList);
                }
                elemAnnotList.Add(this.associationDeclaration_Target_NameUse);
            }
            return base.VisitAssociationDeclaration(context);
        }
        
        public override object VisitIdentifier(MetaModelParser.IdentifierContext context)
        {
            List<object> treeAnnotList = null;
            if (!this.treeAnnotations.TryGetValue(context, out treeAnnotList))
            {
                treeAnnotList = new List<object>();
                this.treeAnnotations.Add(context, treeAnnotList);
            }
            treeAnnotList.Add(this.identifier_Name);
            treeAnnotList.Add(this.identifier_Identifier);
            return base.VisitIdentifier(context);
        }
        
        public override object VisitLiteral(MetaModelParser.LiteralContext context)
        {
            return base.VisitLiteral(context);
        }
        
        public override object VisitNullLiteral(MetaModelParser.NullLiteralContext context)
        {
            return base.VisitNullLiteral(context);
        }
        
        public override object VisitBooleanLiteral(MetaModelParser.BooleanLiteralContext context)
        {
            return base.VisitBooleanLiteral(context);
        }
        
        public override object VisitIntegerLiteral(MetaModelParser.IntegerLiteralContext context)
        {
            return base.VisitIntegerLiteral(context);
        }
        
        public override object VisitDecimalLiteral(MetaModelParser.DecimalLiteralContext context)
        {
            return base.VisitDecimalLiteral(context);
        }
        
        public override object VisitScientificLiteral(MetaModelParser.ScientificLiteralContext context)
        {
            return base.VisitScientificLiteral(context);
        }
        
        public override object VisitStringLiteral(MetaModelParser.StringLiteralContext context)
        {
            return base.VisitStringLiteral(context);
        }
    }
}


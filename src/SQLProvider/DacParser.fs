namespace FSharp.Data.Sql.Providers

open System
open System.ComponentModel
open System.Xml.Serialization
open System.IO.Compression
open System.Xml
open FSharp.Data.Sql.Schema
module DacParser =
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementAnnotationProperty = {

        [<XmlAttribute>]
        Name : string
        
        [<XmlAttribute>]
        Value : string
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntryElementPropertyValue = {

        [<XmlAttribute>]
        QuotedIdentifiers : string
        
        [<XmlAttribute>]
        AnsiNulls : string
        
        [<XmlText>]
        Value : string
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntryElementRelationshipEntryElementProperty = {

        [<XmlAttribute>]
        Name : string
        
        [<XmlAttribute>]
        Value : byte
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementPropertyValue = {

        [<XmlAttribute>]
        QuotedIdentifiers : string

        [<XmlAttribute>]
        AnsiNulls : string

        [<XmlText>]
        Value : string
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntryElementRelationshipEntryElementRelationshipEntryReferences = {
        [<XmlAttribute>]
        ExternalSource : string

        [<XmlAttribute>]
        Name : string
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntryReferences = {
        [<XmlAttribute>]
        ExternalSource : string

        [<XmlAttribute>]
        Name : string

        [<XmlAttribute>]
        Disambiguator : byte

        [<XmlIgnore>]
        DisambiguatorSpecified : bool
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementProperty = {

        Value : DataSchemaModelElementPropertyValue

        [<XmlAttribute>]
        Name : string

        [<XmlAttribute("Value")>]
        Value1 : string
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementAnnotation = {
        [<XmlElement("Property")>]
        Property : DataSchemaModelElementAnnotationProperty[]

        [<XmlAttribute>]
        Type : string
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntryElementRelationshipEntryReferences = {
        [<XmlAttribute>]
        Name : string
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntryElementRelationshipEntryElementRelationshipEntry = {

        References : DataSchemaModelElementRelationshipEntryElementRelationshipEntryElementRelationshipEntryReferences
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntryElementProperty = {

        Value : DataSchemaModelElementRelationshipEntryElementPropertyValue
        
        [<XmlAttribute>]
        Name : string
        
        [<XmlAttribute("Value")>]
        Value1 : string
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntryElementRelationshipEntryElementRelationship = {

        Entry : DataSchemaModelElementRelationshipEntryElementRelationshipEntryElementRelationshipEntry

        [<XmlAttribute>]
        Name : string
    }

    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntryElementRelationshipEntryElement = {

        Property : DataSchemaModelElementRelationshipEntryElementRelationshipEntryElementProperty
        
        Relationship : DataSchemaModelElementRelationshipEntryElementRelationshipEntryElementRelationship
        
        [<XmlAttribute>]
        Type : string
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntryElementRelationshipEntry = {

        Element : DataSchemaModelElementRelationshipEntryElementRelationshipEntryElement
        
        References : DataSchemaModelElementRelationshipEntryElementRelationshipEntryReferences
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntryElementRelationship = {

        Entry : DataSchemaModelElementRelationshipEntryElementRelationshipEntry
        
        [<XmlAttribute>]
        Name : string
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntryElement = {

        [<XmlElement("Property")>]
        Property : DataSchemaModelElementRelationshipEntryElementProperty[]
        
        Relationship : DataSchemaModelElementRelationshipEntryElementRelationship
        
        [<XmlAttribute>]
        Type : string
        
        [<XmlAttribute>]
        Name : string
    }
    
    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationshipEntry = {

        Element : DataSchemaModelElementRelationshipEntryElement
        
        References : DataSchemaModelElementRelationshipEntryReferences
    }

    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElementRelationship = {

        [<XmlElement("Entry")>]
        Entry : DataSchemaModelElementRelationshipEntry[] 
        
        [<XmlAttribute>]
        Name : string
    }

    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    type DataSchemaModelElement = {

        [<XmlElement("Property")>]
        Property : DataSchemaModelElementProperty[]
        
        [<XmlElement("Relationship")>]
        Relationship : DataSchemaModelElementRelationship[]
        
        Annotation : DataSchemaModelElementAnnotation
        
        [<XmlAttribute>]
        Type : string 
        
        [<XmlAttribute>]
        Disambiguator : byte
        
        [<XmlIgnore>]
        DisambiguatorSpecified : bool
        
        [<XmlAttribute>]
        Name : string
    }

    [<Serializable>]
    [<CLIMutable>]
    [<DesignerCategory("code")>]
    [<XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02")>]
    [<XmlRoot(Namespace = "http://schemas.microsoft.com/sqlserver/dac/Serialization/2012/02", IsNullable = false)>]
    type DataSchemaModel = {

        [<XmlArrayItem("Element", IsNullable = false)>]
        Model : DataSchemaModelElement[] 
        
        [<XmlAttribute>]
        FileFormatVersion : decimal
        
        [<XmlAttribute>]
        SchemaVersion : decimal
        
        [<XmlAttribute>]
        DspName : string
        
        [<XmlAttribute>]
        CollationLcid : uint16
        
        [<XmlAttribute>]
        CollationCaseSensitive : string
    }

    let parse (file:string) =
        use zip = ZipFile.Open(file, ZipArchiveMode.Read)
        use modelSteam = zip.GetEntry("model.xml").Open()
        use reader = XmlReader.Create(modelSteam)
        let serializer = new XmlSerializer(typeof<DataSchemaModel>)
        serializer.Deserialize(reader) :?> DataSchemaModel

    let getSchema (element:DataSchemaModelElement) =
        element.Relationship
        |> Array.find (fun i -> i.Name = "Schema")
        |> fun i -> i.Entry
        |> Array.find (fun i -> i.References.ExternalSource = "BuiltIns")
        |> fun i -> i.References.Name

    let getTables (model:DataSchemaModel) =
        model.Model
        |> Seq.filter (fun i -> i.Type = "SqlTable")
        |> Seq.map (fun i -> { Schema = getSchema i; Name = i.Name; Type = i.Type })
        
    let getIndexColumn (element:DataSchemaModelElement) =
        element.Relationship
        |> Array.find (fun i -> i.Name = "ColumnSpecifications")
        |> fun i -> i.Entry
        |> Array.find (fun i -> i.Element.Type = "SqlIndexedColumnSpecification")
        |> fun i -> i.Element.Relationship.Entry.References.Name

    let getPrimaryKey (model:DataSchemaModel) (table:Table) =
        model.Model
        |> Seq.tryFind (fun i -> i.Name = table.FullName && i.Type = "SqlPrimaryKeyConstraint")
        |> Option.map getIndexColumn

    let getColumns (model:DataSchemaModel) (table:Table) findDbType =
        model.Model
        |> Seq.filter (fun i -> i.Type = "SqlTable")
        |> Seq.collect (fun i -> i.Relationship)
        |> Seq.filter (fun i -> i.Name = "Columns")
        |> Seq.collect (fun i -> i.Entry)
        |> Seq.filter (fun i -> i.Element.Type = "SqlSimpleColumn")
        |> Seq.map (fun i -> i.Element)
        |> Seq.choose (fun i ->
            match findDbType i.Relationship.Entry.Element.Relationship.Entry.References.Name with
            | Some ``type`` ->
                {   Column.Name = i.Name
                    TypeMapping = ``type``
                    IsNullable = i.Property |> Seq.find (fun i -> i.Name = "IsNullable") |> fun i -> bool.Parse i.Value1
                    IsPrimaryKey = getPrimaryKey model table |> Option.exists (fun key -> key = i.Name) }
                |> Some
            | None -> None)
        |> Seq.map (fun i -> i.Name, i)
        |> Map.ofSeq

${
    // Enable extension methods by adding using Typewriter.Extensions.*
    using Typewriter.Extensions.Types;

    // Uncomment the constructor to change template settings.
    Template(Settings settings)
    {
        settings.IncludeAllProjects();
    }
}
${
    string ImportDeclarations(Class type)
    {
      List<string> imports = new List<string>();

      foreach(var property in type.Properties)
      {
          if(!property.Type.IsPrimitive || property.Type.IsEnum )
          {
            imports.Add("import {" + GetBaseTypeName(property) + "} from './" + GetBaseTypeName(property) + "'; ");
          }
      }

      if(type.BaseClass != null)
      {
          imports.Add("import {" + type.BaseClass.Name + "} from './" + type.BaseClass.Name + "';");
      }

      return string.Join(Environment.NewLine, imports.Distinct());
    }

    string GetBaseTypeName(Property property) => property.Type.Name.Replace("[]", string.Empty);

    string GetTypeName(Property property) => property.Type.Name;
}

${
    // https://github.com/frhagn/Typewriter/issues/36
    string ClassNameWithExtends(Class c) {
        return c.Name +  (c.BaseClass!=null ?  " extends " + c.BaseClass.Name : "");
    }
}

$Enums(*.Models.*)[
export enum $Name {
    $Values[$Name = $Value,
    ]
}]
$Classes(*.Models.*)[
$ImportDeclarations
export class $ClassNameWithExtends {
    $Properties[
    $name?: $GetTypeName;
    ]
}]

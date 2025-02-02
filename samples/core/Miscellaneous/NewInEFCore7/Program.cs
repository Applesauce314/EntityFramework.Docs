﻿using NewInEfCore7;

public class Program
{
    public static async Task Main()
    {
        await TpcInheritanceSample.Inheritance_with_TPH();
        await TpcInheritanceSample.Inheritance_with_TPT();
        await TpcInheritanceSample.Inheritance_with_TPC();
        await TpcInheritanceSample.Inheritance_with_TPC_using_HiLo();
        await TpcInheritanceSample.Inheritance_with_TPC_using_Identity();

        await ExecuteDeleteSample.ExecuteDelete();
        await ExecuteDeleteSample.ExecuteDeleteTpt();
        await ExecuteDeleteSample.ExecuteDeleteTpc();
        await ExecuteDeleteSample.ExecuteDeleteSqlite();

        await ExecuteUpdateSample.ExecuteUpdate();
        await ExecuteUpdateSample.ExecuteUpdateTpt();
        await ExecuteUpdateSample.ExecuteUpdateTpc();
        await ExecuteUpdateSample.ExecuteUpdateSqlite();

        await JsonColumnsSample.Json_columns_with_TPH();

        // Issue https://github.com/dotnet/efcore/issues/28816 (Json: add support for Sqlite provider)
        // await JsonColumnsSample.Json_columns_with_TPH_on_SQLite();

        await ModelBuildingConventionsSample.No_foreign_key_index_convention();
        await ModelBuildingConventionsSample.Discriminator_length_convention();
        await ModelBuildingConventionsSample.Max_string_length_convention();
        await ModelBuildingConventionsSample.Map_members_explicitly_by_attribute_convention();
        await ModelBuildingConventionsSample.Custom_model_validation_convention();
        await ModelBuildingConventionsSample.No_cascade_delete_convention();
    }
}

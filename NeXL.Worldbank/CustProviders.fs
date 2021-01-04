namespace NeXL.Worldbank
open NeXL.ManagedXll

module CustomizationProviders =

    [<XlWorkbookTypesProvider>]  
    let getWorkbookTypes(workbook : obj) = [|typeof<ControlRibbon>|]
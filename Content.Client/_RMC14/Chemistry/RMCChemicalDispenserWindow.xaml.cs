using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._RMC14.Chemistry;

[GenerateTypedNameReferences]
public sealed partial class RMCChemicalDispenserWindow : DefaultWindow
{
    public RMCChemicalDispenserWindow()
    {
        RobustXamlLoader.Load(this);
    }
}
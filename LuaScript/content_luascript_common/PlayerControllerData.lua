
function GetE0010PlayerController(id)
    local controllerNames = {}
    controllerNames[101003001] = "Chr_000_01_e0010_01_Controller"
    controllerNames[101005001] = "Chr_000_02_e0010_01_Controller"
    controllerNames[101007001] = "Chr_000_03_e0010_01_Controller"
    controllerNames[101004001] = "Chr_500_01_e0010_01_Controller"
    controllerNames[101006001] = "Chr_500_02_e0010_01_Controller"
    controllerNames[101008001] = "Chr_500_03_e0010_01_Controller"
    return controllerNames[id]
end

function GetE0010DownPlayerController(id)
    local controllerNames = {}
    controllerNames[101003001] = "Chr_000_01_DownController"
    controllerNames[101005001] = "Chr_000_02_DownController"
    controllerNames[101007001] = "Chr_000_03_DownController"
    controllerNames[101004001] = "Chr_500_01_DownController"
    controllerNames[101006001] = "Chr_500_02_DownController"
    controllerNames[101008001] = "Chr_500_03_DownController"
    return controllerNames[id]
end

function GetE0010CommonPlayerController(id)
    local controllerNames = {}
    controllerNames[101003001] = "Bea_m_StdController"
    controllerNames[101004001] = "Bea_f_StdController"
    controllerNames[101005001] = "Che_m_StdController"
    controllerNames[101006001] = "Che_f_StdController02"
    controllerNames[101007001] = "Col_m_StdController"
    controllerNames[101008001] = "Col_f_StdController02"
    return controllerNames[id]
end

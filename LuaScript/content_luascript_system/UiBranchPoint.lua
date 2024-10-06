
BranchPointUnit = system.LoadUIToTextBoxAnchor("ui_page_adv_dialog_prefab", "Container_GetBranchPoint_Main", 100)
UiLoadList[#UiLoadList + 1] = BranchPointUnit

function PlayBranchPoint(textId)
    local signal = BranchPointUnit.BranchPointControll("Init",textId)
    if signal ~= nil then
        while signal.IsProccessing() do
            coroutine.yield()
        end
    end
    BranchPointUnit.BranchPointControll("Play",textId)
end

function EndBranchPoint()
    BranchPointUnit.BranchPointControll("End")
end


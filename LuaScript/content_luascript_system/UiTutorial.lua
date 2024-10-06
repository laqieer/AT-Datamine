
TurorialMask = system.LoadUIToTutorial("ui_page_adv_tutorialmask", "TutorailMask", 0)
UiLoadList[#UiLoadList + 1] = TurorialMask


TutorialPopup = system.LoadUIToTutorialRoot("ui_page_ingame_tutorial_prefab", "Com_Popup_Tutorial_S", 100)
UiLoadList[#UiLoadList + 1] = TutorialPopup

TutorialArrow = system.LoadUIToTutorialRoot("ui_page_ingame_tutorial_prefab", "Container_TutorialArrow_Parts", 101)
UiLoadList[#UiLoadList + 1] = TutorialArrow

function set_message_tutorial_popup(messageTag)
    TutorialPopup.SetSimpleTextTag("Message", messageTag)
    wait_tutorial_popup_tap()
end

function set_message_direct_tutorial_popup(message)
    TutorialPopup.SetSimpleText("Message", message)
    wait_tutorial_popup_tap()
end

function set_position_tutorial_popup(x, y)
    TutorialPopup.SetPosition("Popup", x, y)
end

function set_position_target_tutorial_popup(accesserName, offsetX, offestY)
    TutorialPopup.SetPositionTarget("Popup", accesserName, offsetX, offestY)
end

function open_tutorial_popup(accesserName, x, y)
    -- 以前に開いていた文言が残っている可能性があるのでクリアしておく
    TutorialPopup.SetSimpleTextTag("Message", "")
    local playSignal = TutorialPopup.Play("In", true)
    if x == nil then
        x = 0
    end
    if y == nil then
        y = 0
    end

    if accesserName == nil then
        set_position_tutorial_popup(x, y)
    else
        set_position_target_tutorial_popup(accesserName, x, y)
    end
    while playSignal.IsProccessing() do
        coroutine.yield()
    end
end

function wait_tutorial_popup_tap()
    TutorialPopup.SetActive("Input", true)
    TutorialPopup.Input("Input")
    while TutorialPopup.IsProccessing() do
        coroutine.yield()
    end
    TutorialPopup.CancelInput("Input")
    TutorialPopup.SetActive("Input", false)
end

function close_tutorial_popup()
    local playSignal = TutorialPopup.Play("Out", false)
    while playSignal.IsProccessing() do
        coroutine.yield()
    end
end

function set_active_arrow(active)
    TutorialArrow.SetActive(active)
end

function set_position_arrow(x, y)
    TutorialArrow.SetPosition("Arrow", x, y)
end

function set_position_target_arrow(accesserName, x, y)
    TutorialArrow.SetPositionTarget("Arrow", accesserName, x, y)
end

function set_rotation_arrow(zAngle)
    TutorialArrow.SetRotation("Arrow", zAngle)
end

UnmaskObject = {}
function active_tutorial_mask()
    TurorialMask.SetActive(true)
end

function deactive_tutorial_mask()
    TurorialMask.SetActive(false)
end

function set_mask_color(colorCode)
    TurorialMask.SetMaskColor(colorCode)
end

function get_unmask_object(index)
    if #UnmaskObject < index then
        if index == 1 then
            UnmaskObject[#UnmaskObject + 1] = TurorialMask.CreateLoadUI("Unmask")
        else
            UnmaskObject[#UnmaskObject + 1] = UnmaskObject[1].DuplicateUI()
        end
    end
    UnmaskObject[index].SetAsFirstSibling()
    return UnmaskObject[index]
end

function set_unmask(index, x, y, width, height, enableRaycastFilter)
    if x == nil then
        x = 0
    end
    if y == nil then
        y = 0
    end
    if width == nil then
        width = 0
    end
    if height == nil then
        height = 0
    end

    local obj = get_unmask_object(index)
    obj.SetTutorialUnmask(x, y, width, height)
    if index == 1 then
        TurorialMask.EnableUnmaskRaycastFilter(enableRaycastFilter)
    end
end

function set_unmask_fittarget(index, accesserName, imageMask, enableRaycastFilter, offsetX, offsetY, offsetSizeX, offsetSizeY)
    if offsetX == nil then
        offsetX = 0
    end
    if offsetY == nil then
        offsetY = 0
    end
    if offsetSizeX == nil then
        offsetSizeX = 0
    end
    if offsetSizeY == nil then
        offsetSizeY = 0
    end
    local obj = get_unmask_object(index)
    obj.SetTutorialUnmaskTarget(accesserName, imageMask, offsetX, offsetY, offsetSizeX, offsetSizeY)
    if index == 1 then
        TurorialMask.EnableUnmaskRaycastFilter(enableRaycastFilter)
    end
end

function active_unmask(index, active)
    local obj = get_unmask_object(index)
    obj.SetActive(active)
end

function is_accesser_exist(accesserName, activeOnly)
    if activeOnly == nil then
        activeOnly = true
    end
    return system.IsAccesserExist(accesserName, activeOnly)
end


function wait_button_click(accesserName)
    local signal = system.AddTutorialButtonEvent(accesserName)
    while signal.IsProccessing() do
        coroutine.yield()
    end
    system.RemoveTutorialButtonEvent()
end

function wait_ui_animation(accesserName)
    while system.IsPlayingUIAnimation(accesserName) do
        coroutine.yield()
    end
end

function wait_play_ui_animation(accesserName)
    local time = 0
    while not system.IsPlayingUIAnimation(accesserName) do
        if TUTORIAL_DEBUG_MODE then
            time = time + system.GetDeltaTime()
            if time >= 3 then
                break
            end
        end
        coroutine.yield()
    end
end


function wait_get_accesser(accesserName)
    local time = 0
	while not is_accesser_exist(accesserName) do
        if TUTORIAL_DEBUG_MODE then
            time = time + system.GetDeltaTime()
            if time >= 3 then
                break
            end
        end
		coroutine.yield()
	end
end

function untile_get_accesser(accesserName)
	while is_accesser_exist(accesserName) do
		coroutine.yield()
	end
end

function open_tutorial_dialog(tutorialId)
    -- TODO: あとでダイアログを対応
end

function send_tutorial_progless(progless)
    -- TODO: あとで通信を対応
end

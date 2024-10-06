Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")

function Load()
	demo_setup_nofade()
	load_ui()
	Noir = get_chara("Player")
	character2D(Noir, "Noir", "content_unit_101000102", "101000102_UnitFace", "101000102_UnitCutin", "101000102_UnitThumb", "101000102_UnitImage_Full", "101000102_UnitImage_HiRes")
end

function Play()
    demo_start_nofade()
    
    local npc_communication = get_npc_communication()
        if npc_communication.ConditionItem != nil then
            
            local total = npc_communication.TotalDeliveredCount
            local conditionItem = npc_communication.ConditionItem
            local item_name = "『" .. conditionItem.ItemName .. "』"
            local can_rankup = total + conditionItem.UserItemNum >= conditionItem.ItemNum
            if 1 <= conditionItem.UserItemNum then
                -- アイテムを所持
                
                open_narration_window()
                    message_direct(item_name .. "を持ってきてくれたの？")
                    message_direct(item_name .. "を全て渡しますか？")
                close_narration_window()
                
                local result = select()
                if result == true then
                    -- 納品する
                    
                    open_narration_window()
                        message_direct("ありがとう！")
                    close_narration_window()
                    
                    if can_rankup == true then
                    
                        -- ランクアップ
                        open_narration_window()
                            message_direct(npc_communication.CharaName .. "との仲が深まりそうだ。")
                        close_narration_window()
                    
                    end
                else
                    
                    -- 納品しない
                
                end
            else
            
                -- アイテムを所持していない
                open_narration_window()
                    message_direct(item_name .. "を入手したら僕の所に持って来てね")
                close_narration_window()
	        
	            system.Cancel()
            
            end
        end
    demo_end_nofade()
end

function select()
    -- する/しない
	open_select_window_direct(Noir, "Normal", "はい", "いいえ")

	if is_select(1) then	-- はい
	    return true
	elseif is_select(2) then	-- やめる
	    system.Cancel()
		return false
	else

		-- どれも選ばれなかった（エラー）
		system.Cancel()
        return false
	end
end

-- EOF ------------------------------------


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	get_chara_preload("Player")
end

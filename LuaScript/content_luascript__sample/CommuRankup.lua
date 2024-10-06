Include("content_luascript_common","ADVSmallPack")

-- アセットなどを読み込む
function Load()
    -- InitializeLoad()
	manager = CreateAdvSmallManager()
	
    demo_setup_nofade()
    
    commu = get_commu() -- 実行中コミュ

	Talker = get_chara("Dinatan")
	Player = get_chara("Player")
end

-- シーケンスの実行
function Play()

    demo_start_nofade()

    show_current_script()
    
    open_narration_window()
        message_direct("β3コミュテスト/ディナタン")
        message_direct("サンプルスクリプト<color=\"red\"> CommuRankup </color>です。")
    close_narration_window()
    
	CO_101012_00_start()	-- 導入会話
	
	-- 進行条件示唆
    if commu.HasCondition == true then
        local conditionText = commu.GetRankupConditionHintText()
        open_narration_window()
            message_direct(conditionText)
        close_narration_window()
    end
    
    if commu.IsRankup == false then -- ランクアップ条件を満たしていない
        demo_end_nofade()
        system.Cancel()
        return
    end
    
	-- ランクアップ示唆
    local hintText = commu.GetRankupHintText()
    open_narration_window()
        message_direct(hintText)
        
        message_direct("コミュしますか？")
    close_narration_window()
    
    -- 確認
	open_select_window_direct(Player, "Normal", "はい", "いいえ")
    
	if is_select(1) then
		rankup()
	elseif is_select(2) then
		-- いいえ
		CO_101012_00_stop()	-- 断る
		system.Cancel()
        demo_end_nofade()
	else
		-- 例外処理
		system.Cancel()
        demo_end_nofade()
	end
end

function CO_101012_00_start()

	open_speech_window("CHRNAME_DINATAN", Talker, nil)
	message_direct("兄さんどうしたの？")
	close_speech_window()
end

function CO_101012_00_stop()

	open_speech_window("PLAYERNAME_NOIR", Player, nil)
	message_direct("コミュ中断します")
	close_speech_window()

end

function rankup()
    open_narration_window()
        message_direct("β3コミュテスト/ディナタン/ランクアップコミュの演出が再生されます")
    close_narration_window()
end

function get_commu()
    return system.GetCommu()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	get_chara_preload("Dinatan")
	get_chara_preload("Player")
end

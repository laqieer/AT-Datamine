Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "MovieFunctions")

-- アセットなどを読み込む
function Load()
	Load_common(true)

	--ボタン制御
	ShowGlobalMenuButton(false)
	
	--黒帯非表示
	disableTextBox = true

	movie_load("lbm0001")
--	movie_load("MV_hoshimachi")

end

-- シーケンスの実行
function Play()

	fadein(0)
	Play_start(true, true)

--[[
	open_narration_window()
	message_direct_nowait("<align=center>仮：ピックアップスタイル召喚<br>清風が傷痕を勲章に変え　開催中！</align>")
	wait_time(2.0)
	close_narration_window()
]]

	movie_set_active(true)

	movie_play()

	movie_wait_playing()

	movie_stop()
	
	--黒帯表示念のため
	disableTextBox = false
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	disableTextBox = true
	movie_load_preload("lbm0001")
--	movie_load_preload("MV_hoshimachi")
end

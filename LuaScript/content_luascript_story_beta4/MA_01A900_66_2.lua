Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "MovieFunctions")

-- アセットなどを読み込む
function Load()
	Load_common(true)

	--ボタン制御
	ShowGlobalMenuButton(false)
	
	--黒帯非表示
	disableTextBox = true
	
	movie_load("MA_01A000_Preview")
	movie_set_active(true)
	
	movie_play()

end

-- シーケンスの実行
function Play()

	fadein(0)
	Play_start(true, false)

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
	movie_load_preload("MA_01A000_Preview")
end

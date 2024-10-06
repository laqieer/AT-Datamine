Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "MovieFunctions")

-- アセットなどを読み込む
function Load()
	Load_common(true)

	ShowGlobalMenuButton(false)
	disableTextBox = true

	movie_load("MA_01100_04_01")
	--load_sound("SE_ADV_Movie")
	movie_set_active(true)
	movie_play()

end

-- シーケンスの実行
function Play()

	fadein(0)
	Play_start(true)
	SetTrackingId(27)

	movie_wait_playing()
	movie_stop()
	SetTrackingId(28)

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	disableTextBox = true
	movie_load_preload("MA_01100_04_01")
end

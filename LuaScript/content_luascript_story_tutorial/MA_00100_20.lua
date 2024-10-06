Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_system", "MovieFunctions")
Include("content_luascript_common","ADVSmallPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	
	--ボタン制御
	ShowGlobalMenuButton(false)
	
	--取得処理仮
	heroId = GetPlayerStyleId()
	
	
	if heroId == 101003001 then
		mivieId = "MA_00100_20_M1"
		
	elseif heroId == 101005001 then
		mivieId = "MA_00100_20_M2"
		
	elseif heroId == 101007001 then
		mivieId = "MA_00100_20_M3"
		
	elseif heroId == 101004001 then
		mivieId = "MA_00100_20_F1"
		
	elseif heroId == 101006001 then
		mivieId = "MA_00100_20_F2"
	
	else
		mivieId = "MA_00100_20_F3"
	
	end
	
	movie_load(mivieId)
	--load_sound("SE_ADV_Movie")
	SetTrackingId(19)
	movie_set_active(true)
	movie_play()

	load_sound("BGM_ADV_Revataine")

end

-- シーケンスの実行
function Play()

	fadein(0)
	Play_start(true)

	movie_wait_playing()

	movie_stop()
	SetTrackingId(20)

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	heroId = GetPlayerStyleId()
	if heroId == 101003001 then
		mivieId = "MA_00100_20_M1"
	elseif heroId == 101005001 then
		mivieId = "MA_00100_20_M2"
	elseif heroId == 101007001 then
		mivieId = "MA_00100_20_M3"
	elseif heroId == 101004001 then
		mivieId = "MA_00100_20_F1"
	elseif heroId == 101006001 then
		mivieId = "MA_00100_20_F2"
	else
		mivieId = "MA_00100_20_F3"
	end
	movie_load_preload(mivieId)
	preload_sound("BGM_ADV_Revataine")
end

Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

	setup2D_S_Noir(3)

end

-- プレイヤーフェイズ1
function Play()
	Play_start(false)

	SetTrackingId(41)
	--ノワールセリフ
	change_face(Noir3, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir3,nil) --ノワール
	message("BT_20001_0101") --かえせっ！
	close_speech_window()


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Noir_preload(3)
end

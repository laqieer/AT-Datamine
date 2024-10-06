Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()
	
	setup2D_S_Dinatan(3)

end

-- プレイヤーフェイズ1
function Play()

	--ディナタンセリフ
	change_face(Dinatan3, "Sad")
	open_speech_window("CHRNAME_DINATAN",Dinatan3,nil)--ディナタン
	message("BT_20000_0101")--はぁはぁ…待って、兄さん…！
	close_speech_window()


	--ディナタン移動
	unit_command_move_only(2, 8, 11, false)


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Dinatan_preload(3)
end

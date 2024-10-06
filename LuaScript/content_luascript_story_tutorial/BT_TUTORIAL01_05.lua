Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()	

	setup2D_S_Noir(3)
	setup2D_S_Dinatan(3)

end

-- プレイヤーフェイズ2
function Play()

	--ノワール＆ディナタンセリフ
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir3,nil) --ノワール
	message("BT_20000_0801")--ゴメン、ひとりで先行しすぎた
	close_speech_window()


	change_face(Dinatan3, "Normal")
	open_speech_window("CHRNAME_DINATAN",Dinatan3,nil)--ディナタン
	message("BT_20000_0802")--頼りにしてるよ、兄さん！
	close_speech_window()


	-- ディナタンをノワールにダブルさせる指示
	manual_command_double(2, 8, 11, 8, 12)
	--ノワール通常攻撃操作
	manual_command_skill(1, 9, 12, 9, 11, 0)


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Noir_preload(3)
	setup2D_S_Dinatan_preload(3)
end

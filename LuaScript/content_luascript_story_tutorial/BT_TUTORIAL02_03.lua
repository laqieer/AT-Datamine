Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

	setup2D_S_Noir(3)

end

-- プレイヤーフェイズ2
function Play()

	--ノワールセリフ
	change_face(Noir3, "Pain")
	open_speech_window("CHRNAME_NOIR",Noir3,nil) --ノワール
	message("BT_20001_0301")--なんだ？武器の様子がおかしい…

	change_face(Noir3, "Serious")
	message("BT_20001_0302")--くそっ、ほかの武器を使うしかないか
	close_speech_window()


	--ノワール武器変更操作
	manual_command_swap_weapon(1, 2)
	--ノワール通常攻撃操作
	manual_command_skill(1, 10, 13, 11, 13, 0)


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

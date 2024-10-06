Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

--	setup2D_S_MOB01_Soldier(7)

end

-- エネミーフェイズ1
function Play()
	Play_start(false)


	--ログレス兵士セリフ
--	change_face(MOB01_Soldier7, "Normal")
	open_speech_window("NPCNAME_0124",nil,nil) --ログレス兵（キャメロット兵）　モブ兵士の顔は非表示が演出ルール
	message("BT_20000_0502") --貴様ら…よくも！
	close_speech_window()

	--兵士剣攻撃
	unit_command_skill(2000003, 10, 13, 9, 13, 0, false)
	--兵士弓攻撃
	unit_command_skill(2000002, 10, 12, 9, 13, 0, false)

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end

Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()
	
	setup2D_S_Sisters_1()

end

-- エネミーフェイズ1
function Play()

	--モーロノエーセリフ
	change_face(Sisters_1, "Anger")
	open_speech_window("CHRNAME_NAMELES",nil,Sisters_1)--???（モーロノエー）
	message("BT_10000_0901")--無駄なあがきはおやめなさい
	close_speech_window()


	-- 増援
	sortie_troops(3, 2)
	-- モーロノエー攻撃
	unit_command_skill(2000003, 8, 12, 5, 12, 0, false)


	-- 残りのユニット待機、行動済みのユニットは省略
	unit_command_stay(2000002, false)
	-- unit_command_stay(2000003, false)
	-- unit_command_stay(2000004, false)
	unit_command_stay(2000005, false)
	unit_command_stay(2000006, false)
	unit_command_stay(2000007, false)
	-- unit_command_stay(2000008, false)
	-- unit_command_stay(2000009, false)
	-- unit_command_stay(2000010, false)

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Sisters_1_preload()
end

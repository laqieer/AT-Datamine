Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

	setup2D_S_Sisters_1()

end

-- エネミーフェイズ2
function Play()

	--モーロノエーセリフ
	change_face(Sisters_1, "Normal")
	open_speech_window("CHRNAME_NAMELES",nil,Sisters_1)--???（モーロノエー）
	message("BT_10000_1501")--見上げたものね
	close_speech_window()


	-- バルバロイ攻撃
	unit_command_skill(2000011, 5, 12, 5, 11, 0, false)


	-- 残りのユニット待機、行動済みのユニットは省略
	unit_command_stay(2000001, false)
	unit_command_stay(2000002, false)
	-- unit_command_stay(2000003, false)
	-- unit_command_stay(2000004, false)
	unit_command_stay(2000005, false)
	unit_command_stay(2000006, false)
	unit_command_stay(2000007, false)
	-- unit_command_stay(2000008, false)
	-- unit_command_stay(2000009, false)
	-- unit_command_stay(2000010, false)
	unit_command_stay(2000012, false)
	unit_command_stay(2000013, false)
	unit_command_stay(2000014, false)


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

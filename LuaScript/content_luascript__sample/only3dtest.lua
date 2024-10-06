-- β2メイン/MA_01104_01 ---------------------------------------------------------------------------
Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript_story_beta3", "MA_01104_01_h")

-- アセットなどを読み込む
function Load()
	demo_setup()
	load_area_scene(110011) -- ノワール教室：夕晴
	load_sound("BGM_Area_Noon")

-- ------------------------------------------
-- 初期配置（キャラ）

	setup_101009_Noir(No_01_000401_0, "Com_Std01_Loop_m", 0, true)
	setup_101010_Lancelot(La_01_000401_0, "Col_Std02_Loop_m", 0, true)
	setup_101011_Guinevere(Gu_01_000407_0, "Com_Sit02_Loop_f", 0, true)
	setup_101013_Gawain(Ga_01_000401_0, "Com_Sit02_Loop_m", 0, true)
	setup_101018_Ragnar(Ra_01_000401_0, "Com_Sit02_Loop_f", 0, true)
	setup_101012_Dinatan(Di_01_000402_0, "Bea_Std02_Loop_f", 0, true)
	
	--lookat_weight(Noir, 1, 0.1, 1, 0.5)
	lookat_weight_default(Lancelot)
	
-- ------------------------------------------
-- カメラ設定	
	CUT_CAMERA1	= set_camera(Camera_01_0401_01)	
	CUT_CAMERA2	= set_camera(Camera_01_0401_02) 
	CUT_CAMERA3	= set_camera(Camera_01_0401_03)
	CUT_CAMERA4	= set_camera(Camera_01_0401_04)
	CUT_CAMERA5	= set_camera(Camera_01_0401_05)
	CUT_CAMERA6	= set_camera(Camera_01_0402_06)
	CUT_CAMERA7	= set_camera(Camera_01_0402_07)
	CUT_CAMERA8	= set_camera(Camera_01_0402_08)
	CUT_CAMERA9	= set_camera(Camera_01_0402_09)

-- シーン04、05（カット11、12）は回想、絵コンテ化されていないので飛ばし
	CUT_CAMERA10 = set_camera(Camera_01_0403_10)--黒背景の座標
--	CUT_CAMERA11 = set_camera(Camera_01_0404_11)--ナンバリングのみ、後日作成
--	CUT_CAMERA12 = set_camera(Camera_01_0405_12)--ナンバリングのみ、後日作成

	CUT_CAMERA13 = set_camera(Camera_01_0406_13)
	CUT_CAMERA14 = set_camera(Camera_01_0406_14)
	CUT_CAMERA15 = set_camera(Camera_01_0406_15)
	CUT_CAMERA16 = set_camera(Camera_01_0406_16)
	CUT_CAMERA17 = set_camera(Camera_01_0406_17)
	CUT_CAMERA18 = set_camera(Camera_01_0406_18)

-- ------------------------------------------
end

-- シーケンスの実行
function Play()
	on_camera(CUT_CAMERA1)
	demo_start()
	show_current_script()

--[[
	MA_01104_010003	@先生	では、自己紹介を────
	MA_01104_010004	@ノワール	…
	MA_01104_020002	@ディナタン	（……………同じくらいの年の人が、沢山）
	MA_01104_020003	@ディナタン	（私たち…………戦ってたんだ）
	MA_01104_030002	@傭兵A	張りつめてんなあ、坊主
	MA_01104_030004	@傭兵B	ンな気負うなよ、大将ォ<br>やっと念願が叶うってだけじゃねえか
	MA_01104_030006	@傭兵A	良かったな、坊主<br>初体験の楽しみが増えて
	MA_01104_030008	@ディナタン	私、兄さんについていくから<br>どういう結果になっても
	MA_01104_040002	@ブルーノ	…急がなくていいんだ、ノワール
								<br>お前の武器をゆっくり見つければいい
	MA_01104_050002	@母	置き去りにしちゃうね
	MA_01104_060002	@ランスロット	では、自己紹介を
	MA_01104_060003	@ノワール	………
	MA_01104_060005	@テロップ	@テロップ	『世界平和を叶える聖杯を探し求め<br>その聖杯へ導く妖精さんを守る騎士…!!』
	MA_01104_060006	@ノワール	ノワールです
	MA_01104_060007	@テロップ	『俺は、円卓の騎士になるんだ!!』
	MA_01104_060008	@ノワール	追いつけるように、がんばります
]]


-- カット4 ----------------------------------------------------------------------------------------
	on_camera(CUT_CAMERA4)
	local No_01_000406_0_pos2 = {-1.6,0,-5.36, 0}
	local La_01_000406_0_pos2 = {-0.07, 0, -5.554, 0}
	local Di_01_000406_0_pos2 = {-0.57, 0, -4.638, 0}
	
	set_pos(Noir, No_01_000406_0_pos2) --ノワール位置調整
	set_rot(Lancelot, La_01_000406_15_rot) --ランスロット位置調整
	set_pos(Dinatan, Di_01_000406_0_pos2)
	
	set_camera_lookat(CUT_CAMERA15, -2.18, 0.55, -4.793) --注視点
	
	open_speech_window_only3d("CHRNAME_NOIR", Noir, nil)
	message_direct("keep_ik_lookat(Noir, Dinatan, J_Head)　lookat_delay_weight_default(Noir, 1) 旋回速度等倍")
	close_mind_window()
	
	--初回設定時等weightが設定されていない場合は注視目標を設定したあとで
	keep_ik_lookat(Noir, Dinatan, "J_Head")
	--weightの設定を行う。ここの順番を間違えると挙動が不自然になる
	lookat_delay_weight_default(Noir, 1)
	
	open_simple_window_only3d("CHRNAME_NOIR", Noir, nil)
	message_direct("keep_delay_ik_lookat(Noir, Lancelot, J_Head, 0.5) 旋回速度半分")
	close_mind_window()
	
	demo_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_area_scene_preload(110011)
	setup_101009_Noir_preload(No_01_000401_0, "Com_Std01_Loop_m", 0, true)
	setup_101010_Lancelot_preload(La_01_000401_0, "Col_Std02_Loop_m", 0, true)
	setup_101011_Guinevere_preload(Gu_01_000407_0, "Com_Sit02_Loop_f", 0, true)
	setup_101013_Gawain_preload(Ga_01_000401_0, "Com_Sit02_Loop_m", 0, true)
	setup_101018_Ragnar_preload(Ra_01_000401_0, "Com_Sit02_Loop_f", 0, true)
	setup_101012_Dinatan_preload(Di_01_000402_0, "Bea_Std02_Loop_f", 0, true)
end

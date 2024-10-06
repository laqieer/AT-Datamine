-- このluaスクリプトは、PT5_01_0052_2.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
-- ▼直接出力
MobsNo = 2
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
hideobj01 =get_object("geo_desk_item_02")
hideobj02 =get_object("geo_desk_item_04")
hideobj03 =get_object("geo_desk_item_07")
hideobj04 =get_object("geo_desk_item_10")
hideobj05 =get_object("geo_desk_item_13")
set_pos(hideobj01,{0,-20,0})
set_pos(hideobj02,{0,-20,0})
set_pos(hideobj03,{0,-20,0})
set_pos(hideobj04,{0,-20,0})
set_pos(hideobj05,{0,-20,0})
hideobj06 =get_object("geo_desk_item_06")
hideobj07 =get_object("geo_desk_item_15")
hideobj08 =get_object("geo_desk_item_16")
hideobj09 =get_object("geo_desk_item_01")
set_pos(hideobj06,{0,-20,0})
set_pos(hideobj07,{0,-20,0})
set_pos(hideobj08,{0,-20,0})
set_pos(hideobj09,{0,-20,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ケイ★★:諸君ら学園の生徒のなかには<br>ログレス以外の国の出身者も多い
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "納得")
-- ▲直接出力

	--★★ケイ★★:ゆえに今回は、この国を築いた偉大なる王<br>ユーサー・ペンドラゴンについて語ろう
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:ノワールよ<br>ユーサー王の異名は知っているだろうな？
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520004")

	open_select_window_tag(Actor001,"Normal","PT5_01_00520005","PT5_01_00520006","PT5_01_00520007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:『ブリテンの赤き竜』だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00520008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:ユーサー王の異名は有名だからな<br>知っていて当然か
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん…英雄王、だったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00520010")

-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:ユーサー王は<br>英雄と呼ばれるにふさわしい活躍をされたが
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ケイ★★:正しくは<br>『ブリテンの赤き竜』だ
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520012")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:聞いたことがないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00520013")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:…やれやれ<br>正解は『ブリテンの赤き竜』だ
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520014")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:その異名が表すように<br>ユーサー王はとても勇敢なお方で
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520015")


	--★★ケイ★★:戦となれば自ら武器をもち<br>兵士たちの先頭に立って戦われたと聞く
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:また、同時にとても聡い方でもあり<br>バルバロイの危険性をいち早く理解し
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:ゲシュタルト・シフトや<br>キラーズについての研究も進められていた
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520018")


	--★★ケイ★★:アーサー王が産まれて間もなくの頃<br>城がバルバロイに襲われ
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520019")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ケイ★★:そのときにイグレーヌ王妃を亡くされたことが<br>研究に乗り出した理由と聞いている
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520020")

-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:そんなユーサー王だが<br>８年前、バルバロイとの戦で致命傷を負い
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ケイ", "悲しみ")
-- ▲直接出力

	--★★ケイ★★:ほどなくして帰らぬ人となった
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520022")

	change_face(Actor002,"Normal")

	--★★ケイ★★:諸君らがこうしてログレスに暮らし<br>ＧＳについて学べているのは
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:ひとえにユーサー王のご尽力の賜物である<br>日々、感謝の思いを忘れることのないようにな
	Talk(Actor002,"CHRNAME_KAY","speech","L","PT5_01_00520024")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

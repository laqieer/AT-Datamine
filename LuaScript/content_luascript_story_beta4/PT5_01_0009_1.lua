-- このluaスクリプトは、PT5_01_0009_1.csvから自動生成されました --
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
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
hideobj01 =get_object("geo_desk_item_02")
hideobj02 =get_object("geo_desk_item_04")
hideobj03 =get_object("geo_desk_item_07")
hideobj04 =get_object("geo_desk_item_10")
hideobj05 =get_object("geo_desk_item_13")
-- ▲直接出力
-- ▼直接出力
set_pos(hideobj01,{0,-20,0})
set_pos(hideobj02,{0,-20,0})
set_pos(hideobj03,{0,-20,0})
set_pos(hideobj04,{0,-20,0})
set_pos(hideobj05,{0,-20,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ブレイズ", "挨拶")
-- ▲直接出力

	--★★ブレイズ★★:『淘汰』と呼ばれる現象について<br>耳にしたことはあるかの？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090002")


	--★★ブレイズ★★:世界にバルバロイが溢れ<br>穢れが限界にまで達したときに起こるもので
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090003")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:淘汰のさいには<br>空が泣き、大地が震えるという
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090004")

	open_select_window_tag(Actor001,"Normal","PT5_01_00090005","PT5_01_00090006","PT5_01_00090007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:淘汰は<br>世界が終わってしまう前兆なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00090008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:うむ<br>伝承ではそういわれておる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:淘汰はバルバロイが引き起こすのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00090010")

-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:どうなんじゃろうのう？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090011")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:バルバロイが淘汰を起こすのか<br>淘汰の前にバルバロイが発生するのか
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:そのあたりも定かではないのじゃよ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090013")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:起きてしまう前に<br>バルバロイをすべて倒すことができれば
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00090014")

	change_face(Actor001,"Normal")

	--★★ノワール★★:淘汰を未然に防げるんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00090015")

-- ▼直接出力
PlayPartVoice("ブレイズ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ふぉっふぉ！<br>実に若者らしい意見じゃ。善哉善哉
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090016")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:淘汰の刻の訪れは世界の終わりの始まり<br>…それが言い伝えじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090017")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:じゃが本当にそうなのじゃろうか？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ブレイズ", "怒り")
-- ▲直接出力

	--★★ブレイズ★★:淘汰によって世界が滅んだのであれば<br>そのことを伝えたのは誰なのじゃ？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090019")


	--★★ブレイズ★★:ワシらの世界が今こうして続いているのは<br>過去の人々が淘汰を乗り越えたからではないか？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:…などと<br>年甲斐もなく希望を抱いてしまうのじゃよ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00090021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
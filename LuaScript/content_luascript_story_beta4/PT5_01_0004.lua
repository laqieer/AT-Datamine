-- このluaスクリプトは、PT5_01_0004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
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
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "挨拶")
-- ▲直接出力

	--★★ブレイズ★★:今日は<br>バルバロイ憑きについて話していこうかの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040002")


	--★★ブレイズ★★:以前、バルバロイは人間の記憶と喰らうと<br>説明したと思うんじゃが…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040003")


	--★★ブレイズ★★:バルバロイのなかには<br>人に取り憑く能力をもつものもおる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ブレイズ", "怒り")
-- ▲直接出力

	--★★ブレイズ★★:人に取り憑き、記憶を少しずつ奪いながら<br>その者に成り代わっていくのじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040005")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:…ノワール？<br>なにか質問があるような顔じゃの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00040007","PT5_01_00040008","PT5_01_00040009")
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
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:人間に成り代わって<br>バルバロイはなにをするつもりなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00040010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:ワシにも<br>バルバロイどもの目的はよくわからんが
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040011")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:バルバロイではなく<br>人としての姿をもたねばならぬこと
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:…そんなものがあるのかもしれぬな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:取り憑かれたあと<br>その人間はどうなるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00040014")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:前回話したことと同じく
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040015")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:すべての記憶が喰われてしまったら<br>その者の存在は世界から失われてしまうじゃろう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040016")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:…ただ<br>これはワシも文献で目にしただけじゃが
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:強い意志の力で<br>取り憑いたバルバロイをねじ伏せられれば
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040018")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:人間としての記憶や自我を保ったまま<br>バルバロイの力を得ることができるとも聞く
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや<br>特に質問はないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00040020")

-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:む？<br>そうじゃったか、すまんの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040021")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:ひょっとすればこのクラスのなかにも<br>『バルバロイ憑き』が潜んでおるかもしれんの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040022")

-- ▼直接出力
PlayPartVoice("ブレイズ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:冗談じゃよ<br>ふぉっふぉっふぉ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00040023")

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
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

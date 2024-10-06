-- このluaスクリプトは、PT5_01_0044_1.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:この島には人間が作ったとは思えない遺物が<br>いくつか存在しているわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440002")


	--★★クリスティーナ★★:たとえばコルベニック城の近くに建つ巨大な壁<br>通称ハドリアヌス・ウォール
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440003")


	--★★クリスティーナ★★:これは壁の周囲に<br>眼には見えない力場が発生していて
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:悪しき者の<br>コルベニック領への侵入を防いでいるそうなの
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440005")


	--★★クリスティーナ★★:この力場はコルベニック城の城主が<br>魔法で発生させているということだけど
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440006")

	PlayAction(Actor005,"to  Std_Talk")

	--★★クリスティーナ★★:ウォールや力場を発生する仕掛けを作ったのは<br>別の時代の別の人間とされているわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440007")


	--★★クリスティーナ★★:それから、今は機能していないようだけど<br>この島の中央には似たような壁の残骸があるし
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力

	--★★クリスティーナ★★:島のどこかにこの力場と同じような技術で<br>その姿を隠す国もあったといわれているわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440009")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:これらの建造物は<br>どんな経緯で作られたものなのかしらね
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440010")

	open_select_window_tag(Actor001,"Normal","PT5_01_00440011","PT5_01_00440012","PT5_01_00440013")
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

	--★★ノワール★★:誰かがなにかを<br>守ったり隠したりしようとしたんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00440014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:たとえば妖精とか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00440015")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:妖精…そうね<br>そう考えると辻褄があう部分もあるわね
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:遠い昔の戦争で使われた<br>道具だったり武器だったりするのかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00440017")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:人々の進化の歴史は戦争の歴史である…<br>たしかにその線も考えられるわね
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440018")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:大昔から存在しているものなんだろ？<br>だったら俺にはわからないな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00440019")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:そうよね…。文献にもこれらの建造物の<br>たしかな用途は記されていないわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440020")

	goto Block1end

::Block1end::
	PlayAction(Actor005,"to  Std_Worry")
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:これは私の推測でしかないのだけれど
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440021")


	--★★クリスティーナ★★:ハドリアヌス・ウォールをはじめとした建造物は<br>同じ、ないし近しい目的のために
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440022")

	PlayAction(Actor005,"to  Std_Talk")

	--★★クリスティーナ★★:過去の人間たちが作り上げたものだと思うの
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力

	--★★クリスティーナ★★:なぜそう思うのかって？<br>それはカンタンよ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440024")


	--★★クリスティーナ★★:過去の叡智の結晶が現在にも残り<br>今もなお活動を続けている…
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440025")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:ロマンは時代を超えても<br>色褪せないものなのだから♪
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00440026")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

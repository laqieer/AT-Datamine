-- このluaスクリプトは、PT5_01_0036_1.csvから自動生成されました --
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
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力

	--★★クリスティーナ★★:今回も<br>コルベニック王国についてのお話よ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360001")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:前回、ログレスとコルベニック王国とのあいだに<br>交流があると説明したと思うけれど
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360002")


	--★★クリスティーナ★★:それはコルベニック城の異名と<br>円卓の騎士の目的からも明らかよね
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:ノワールちゃん<br>円卓の騎士の目的ってなんだったかしら？
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00360005","PT5_01_00360006","PT5_01_00360007")
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

	--★★ノワール★★:「世界平和の願いを叶える聖杯を探し求め<br>その聖杯へ導く妖精を守る」だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00360008")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:正解！<br>すらすら言えるのね、素晴らしいわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:最強を目指す…だったかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00360010")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "落胆")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:たしかにコルベニック城にも<br>騎士団があるけど…不正解よ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360011")

	change_face(Actor005,"Sad")

	--★★クリスティーナ★★:あてずっぽうで答えるのは<br>あまり感心しないわね
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360012")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:円卓の騎士の目的？<br>えっと、なんだったかな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00360013")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:小さい頃はそらで言えたはずなんだけど<br>ごめん、ド忘れした
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00360014")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "落胆")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★クリスティーナ★★:「世界平和の願いを叶える聖杯を探し求め<br>その聖杯へ導く妖精を守る」よ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360015")

	goto Block1end

::Block1end::
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:円卓の騎士の目的が<br>聖杯に関係しているのだから
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360016")

	PlayAction(Actor005,"to  Std_Talk")

	--★★クリスティーナ★★:聖杯城の異名をもつコルベニック城と<br>関係性が深いのは理解に難くないわよね
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360017")


	--★★クリスティーナ★★:過去にログレスから<br>騎士が派遣されたこと聞いたこともあるし
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力

	--★★クリスティーナ★★:数年前、コルベニック城にも<br>銀卓騎士団という騎士団が結成されているわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360019")


	--★★クリスティーナ★★:これから大きな戦いがあるかもしれないけど
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360020")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:円卓の騎士と銀卓騎士団が協力すれば<br>きっとどんな窮地も乗り越えられるわよね♪
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00360021")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

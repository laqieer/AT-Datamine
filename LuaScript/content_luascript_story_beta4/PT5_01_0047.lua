-- このluaスクリプトは、PT5_01_0047.csvから自動生成されました --
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

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:この島の東部には<br>たくさんの山が存在するのだけれど
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00470002")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:そのなかでももっとも標高の高いのが<br>スノードン山よ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00470003")


	--★★クリスティーナ★★:スノードン山はそれだけではなくて<br>霊峰としても知られているわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00470004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:山頂は常に神々しい気に満ち<br>訪れた者にパワーを与えてくれるんですって
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00470005")

	PlayAction(Actor005,"to Greet_one")

	--★★クリスティーナ★★:ここまで聞いて登ってみたいと思った人<br>手を上げて？
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00470006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00470007","PT5_01_00470008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to Sit01_RH01")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:有名なパワースポットなら<br>ぜひ行ってみたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00470009")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:そうそう<br>当然そう思うわよね？
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00470010")

	PlayAction(Actor005,"to  Std_Worry")
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:私も素敵な王子様に出会う運をもらうために<br>今度行ってみようと思っているわ♪
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00470011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや…俺はいいかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00470012")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★クリスティーナ★★:あら？<br>ノワールちゃん、ノリが悪いわね…
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00470013")

	goto Block1end

::Block1end::
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:もしも登山しようと思っているのなら<br>止めはしないけれど、準備は入念にね？
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00470014")


	--★★クリスティーナ★★:スノードン山の登山道は険しいうえに<br>山頂付近は常に吹雪いていると聞くわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00470015")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力

	--★★クリスティーナ★★:散歩気分で行ったりなんかしたら<br>遭難しちゃうこと間違いなしなんだから
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00470016")

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

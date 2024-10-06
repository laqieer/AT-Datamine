-- このluaスクリプトは、MS_002_044.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation08","DuelCommonFormation08_h")
Include("content_adv_advsmall_duelcommonformation08","TemplateDuelCommonFormation08_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_523_02_ms0002_01_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation08,CameraPosDuelCommonFormation08_001)
	Camera002 = SetTemplate("Actor002",180,CharaPosDuelCommonFormation08_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation08,CameraPosDuelCommonFormation08_002)
	Camera003 = SetPlayerTemplate("Actor003",nil,CharaPosDuelCommonFormation08_017,CameraAssetBundleNameDuelCommonFormation08,CameraPosDuelCommonFormation08_017)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation08_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_battle_f_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation08,CameraPosDuelCommonFormation08_002)
	InitializeTemplateRandomCameraDuelCommonFormation08()
	InitializeTemplateDuelCommonFormation08()
-- ▼直接出力
set_enable_auto_lookat_all(false)

CUT_10 =  cat_template_camera("P10_Cam")
CUT_11 =  cat_template_camera("P11_Cam")
CUT_12 =  cat_template_camera("P12_Cam")
CUT_13 =  cat_template_camera("P13_Cam")
CUT_14 =  cat_template_camera("P14_Cam")
CUT_15 =  cat_template_camera("P15_Cam")
CUT_16 =  cat_template_camera("P16_Cam")
CUT_17 =  cat_template_camera("P17_Cam",Actor003)
CUT_18 =  cat_template_camera("P18_Cam")
CUT_19 =  cat_template_camera("P19_Cam")
CUT_20 =  cat_template_camera("P20_Cam")
CUT_21 =  cat_template_camera("P21_Cam")
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
RndCamera001=CUT_10
DontChangeRandomCamera(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060013)
	Actor001 = InitializeCharacter_3D("101070","002","101070002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101002","001","101002001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializePlayerCharacter("Actor003")
	Actor004 = InitializeCharacter_3D("101002","001","101002001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1.35)
setup_small_camera_start(CUT_11)
wait_time(1.35)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0021")
-- ▲直接出力
	change_face(Actor001,"Special")

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440004")

	change_face(Actor004,"Sad")

	--★★レーヴァテイン2★★:ボロボロ泣いてるあなたに<br>言われたくない
	Talk(Actor004,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440005")


	--★★フライクーゲル★★:うっ、うぅう…
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440006")


	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440008")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0019")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★レーヴァテイン2★★:…言ってることが<br>わかんないんだけど
	Talk(Actor004,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440009")

-- ▼直接出力
setup_small_camera_start(CUT_12)
PlayActionDirect(Actor001,"to MS002_044_Cry01_Start")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0062")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:ダーリンの、今までの学園生活──…<br>ぜんぶ…なくなっちゃった
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440011")


	--★★フライクーゲル★★:過去は消えて…未来は決められてて<br>そんなの、息苦しいばっかだよ…？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440012")


	--★★フライクーゲル★★:ダーリンに「きみの自由だ」って<br>言ってあげられるひとがいなきゃ──
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440013")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0021")
-- ▲直接出力
	change_face(Actor001,"Special")

	--★★フライクーゲル★★:もうムリしなくていいんだよって<br>言ってあげるひとが、ひとりでもいなきゃ──
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440014")

-- ▼直接出力
setup_small_camera_start(CUT_13)
Hide(Actor004)
Appear(Actor002)
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101070001_sp_0001_3")
-- ▲直接出力

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440016")


	--★★フライクーゲル★★:逃げ場がないままなんて<br>つらいよ…
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440017")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0008")
-- ▲直接出力

	--★★レーヴァテイン★★:
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440019")

-- ▼直接出力
setup_small_camera_start(CUT_14)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0023")
-- ▲直接出力

	--★★フライクーゲル★★:撃つわけないよ<br>……撃てるわけない
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440020")


	--★★フライクーゲル★★:レーヴァやロンギヌスだって<br>置いて行きたくないよ…っ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440021")


	--★★フライクーゲル★★:でも…でも、ダーリンを放っておけないよ…
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440022")


	--★★フライクーゲル★★:どこ行ったって敵がさ、いっぱい出てきてさ<br>撃っても撃っても終わらないんだよ…？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440023")

-- ▼直接出力
setup_small_camera_start(CUT_15)
PlayActionDirect(Actor001,"to MS002_044_Sit10_Start")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0062")
-- ▲直接出力

	--★★フライクーゲル★★:もう、どこ撃ったらいいか<br>………わかんない
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440025")

-- ▼直接出力
setup_small_camera_start(CUT_16)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0002")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★レーヴァテイン★★:
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440028")


	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440029")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★レーヴァテイン★★:…あなたが言ったこと<br>なにひとつ間違ってないと思う
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440030")

	change_face(Actor002,"Sad")

	--★★レーヴァテイン★★:
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440031")

	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:…
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440032")

	PlayAction(Actor002,"to  Std_No")

	--★★レーヴァテイン★★:逃げた先には<br>また別の不自由がある
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440033")

	change_face(Actor002,"Normal")

	--★★レーヴァテイン★★:背後からは元々あった不自由が追ってくる<br>最後の最後までずっとそう
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440034")

-- ▼直接出力
setup_small_camera_start(CUT_11)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0053")
-- ▲直接出力

	--★★レーヴァテイン★★:「<%player>に犠牲を<br>強いる世界なんかじゃ、息できない」
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440035")

	change_face(Actor002,"Anger")

	--★★レーヴァテイン★★:
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440037")

	change_face(Actor002,"Normal")

	--★★レーヴァテイン★★:もがいてるときの苦しさは<br>一緒にもがいてみないとわからないと思う
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440038")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,330,0.85)
wait_time(0.85)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(1.35)
setup_small_camera_start(CUT_17)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★レーヴァテイン★★:そうでしょ<br><%player>
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440039")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT_18)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,0.416, 0, 2.597,3.35)
wait_time(3.35)
PlayActionDirect(Actor003,"to Std_Loop")
--レーヴァ振り向き
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,180,0.85)
wait_time(0.85)
PlayActionDirect(Actor002,"to Std_Loop")

PlayActionDirect(Actor001,"to MS002_044_Sit10LookUp_Start")
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101070001_sp_0001_3")
-- ▲直接出力

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440043")


	--★★フライクーゲル★★:きみは、学園に残る──…？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440044")

	open_select_window_tag(Actor003,"Normal","MS_002_0440046")
	if is_select(1) then
		goto Block1_1
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:…わたし、を…？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440050")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(CUT_19)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101002001_sp_0002_1")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★レーヴァテイン★★:フライクーゲル。あなたは逃避行の責任を<br>自分だけが背負えばいいと考えてる
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440051")


	--★★レーヴァテイン★★:そうすれば<%player>が<br>万が一、選択を悔やんだとき──
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440052")


	--★★レーヴァテイン★★:
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440053")

	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:…なんで、なんで言い切れるの
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440054")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0053")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★レーヴァテイン★★:私も同じようなこと<br>…してたから
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440055")

	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:…！
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440056")

-- ▼直接出力
setup_small_camera_start(CUT_20)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★レーヴァテイン★★:だから<%player>は<br>自分ですべきことを選んでくれるんだよ
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440057")


	--★★レーヴァテイン★★:…このあと、どうするかは──
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440058")

	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440059")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力

	--★★レーヴァテイン★★:…うん
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440060")

-- ▼直接出力
CloseTalkWindow()
wait_time(2.35)
setup_small_camera_start(CUT_21)
PlayActionDirect(Actor001,"to MS002_044_Sit10_End")
wait_time(1.35)
-- ▲直接出力

	--★★フライクーゲル★★:………ねえ、レーヴァ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440062")

	PlayAction(Actor001,"to  Std_Talk")

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440063")


	--★★フライクーゲル★★:敵の強さは悪魔的にガチヤバ目<br>ダーリン頼りの一点突破もできなさげ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440064")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★レーヴァテイン★★:…そうだね
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440065")

	change_face(Actor001,"Anger")

	--★★フライクーゲル★★:勝つためのプランはある？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440066")

	PlayAction(Actor002,"to  Std_Talk")

	--★★レーヴァテイン★★:学園お泊り会
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440067")

-- ▼直接出力
setup_small_camera_start(CUT_12)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:………パードゥン？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440068")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★レーヴァテイン★★:
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0440069")

	PlayAction(Actor001,"to  Std_Surp")

	--★★フライクーゲル★★:学園お泊り会？ 
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0440070")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101060013)
	InitializeCharacter_3D_Preload("101070","002","101070002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101002","001","101002001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101002","001","101002001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation08)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

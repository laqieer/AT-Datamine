-- このluaスクリプトは、EA_010_013.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation06","DuelCommonFormation06_h")
Include("content_adv_advsmall_duelcommonformation06","TemplateDuelCommonFormation06_h")
-- ▼直接出力

Include("content_luascript_common","PlayerControllerData")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation06_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation06,CameraPosDuelCommonFormation06_002)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPosDuelCommonFormation06_014,CameraAssetBundleNameDuelCommonFormation06,CameraPosDuelCommonFormation06_014)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation06_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation06,CameraPosDuelCommonFormation06_003)
	InitializeTemplateRandomCameraDuelCommonFormation06()
	InitializeTemplateDuelCommonFormation06()
-- ▼直接出力
heroId = GetPlayerStyleId()
if heroId == 101003001 then
	heroIdshort = 101003
	Yof=1.6
elseif heroId == 101005001 then
	heroIdshort = 101005
	Yof=1.6
elseif heroId == 101007001 then
	heroIdshort = 101007
	Yof=1.6
elseif heroId == 101004001 then
	heroIdshort = 101004
	Yof=1.45
elseif heroId == 101006001 then
	heroIdshort = 101006
	Yof=1.45
else
	heroIdshort = 101008
	Yof=1.45
end
initialize_MA0010023(heroIdshort)
-- ▲直接出力
-- ▼直接出力
CUT10 =  cat_template_camera("P10_Cam")
CUT11 =  cat_template_camera("P11_Cam")
CUT12 =  cat_template_camera("P12_Cam")
CUT13 =  cat_template_camera("P13_Cam")
CUT14 =  cat_template_camera("P14_Cam", Actor002)
CUT16 =  cat_template_camera("P16_Cam")
CUT17 =  cat_template_camera("P17_Cam")
CUT18 =  cat_template_camera("P18_Cam")
CUT19 =  cat_template_camera("P19_Cam")
CUT20 =  cat_template_camera("P20_Cam")
CUT21 =  cat_template_camera("P21_Cam")
CUT22 =  cat_template_camera("P22_Cam")
CUT23 =  cat_template_camera("P23_Cam")
CUT24 =  cat_template_camera("P24_Cam")
CUT25 =  cat_template_camera("P25_Cam")
CUT26 =  cat_template_camera("P26_Cam")
-- ▲直接出力
-- ▼直接出力
load_image("201010160", "content_still_20101016_image", "201010160_StillImage")
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("201010170", "content_still_20101017_image", "201010170_StillImage")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_start_pose")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
RndCamera001=CUT10
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101220011)
	Actor001 = InitializeCharacter_3D("101002","001","101002001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	Actor003 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(2.5)
setup_small_camera_start(CUT11)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,90,0.35)
wait_time(0.35)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.5)
setup_small_camera_start(CUT12)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0002")
-- ▲直接出力

	--★★レーヴァテイン★★:痛いことは、なかった？
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130004")

	open_select_window_tag(Actor002,"Normal","EA_010_0130006")
	if is_select(1) then
		goto BlockEA_010_013_1_1
	end

::BlockEA_010_013_1_1::
	CloseTalkWindow()
	goto BlockEA_010_013_1end

::BlockEA_010_013_1end::
-- ▼直接出力
CloseTalkWindow()
--主人公会話
setup_small_camera_start(CUT13)
-- ▲直接出力

	--★★レーヴァテイン★★:…あなたが過去の歴史へ潜っているあいだ<br>こちらの時間は極めて緩やかに流れてた
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130008")


	--★★レーヴァテイン★★:だから、あなたと別れてから今まで<br>私にとっては、ほんの少しの時間だったけど
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130009")

	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:あなたは…過去の継承者とともに<br>たくさん心を痛めた。違う？
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130010")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
setup_small_camera_start(CUT14)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:………<%player>？
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130012")

	open_select_window_tag(Actor002,"Normal","EA_010_0130014")
	if is_select(1) then
		goto Block1_1
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
--主人公会話
setup_small_camera_start(CUT16)
-- ▲直接出力
	goto Block1end

::Block1end::

	--★★レーヴァテイン★★:…？<br>なんのこと、って──
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130016")

	open_select_window_tag(Actor002,"Normal","EA_010_0130018","EA_010_0130019","EA_010_0130020")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0029")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130026")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0029")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130026")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0029")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130026")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start(CUT17)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","EA_010_0130028","EA_010_0130029","EA_010_0130030")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	elseif is_select(3) then
		goto Block3_3
	end

::Block3_1::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,0,0.35)
wait_time(0.35)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★Player★★:
	Talk(Actor002,"PLAYERNAME_GENDAI","mind","L","EA_010_0130033")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
	change_face(Actor002,"Sad")

	--★★Player★★:
	Talk(Actor002,"PLAYERNAME_GENDAI","mind","L","EA_010_0130036")

	goto Block3end

::Block3_3::
	CloseTalkWindow()
	change_face(Actor002,"Surprise")

	--★★Player★★:
	Talk(Actor002,"PLAYERNAME_GENDAI","mind","L","EA_010_0130039")

	goto Block3end

::Block3end::
-- ▼直接出力
setup_small_camera_start(CUT18)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0024")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★レーヴァテイン★★:ま、待ってよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130041")


	--★★レーヴァテイン★★:なにこれ<br>………どういう、こと…？
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130042")

-- ▼直接出力
CloseTalkWindow()
--鈴の音、その音でレーヴァ振り返り
Appear(Actor003)
se_play("SE_ADV_MA_00100_15_Bell_Cat")
wait_time(1.5)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,20,0.35)
wait_time(0.35)
PlayActionDirect(Actor001,"to Std_Loop")
setup_small_camera_start(CUT19)
turn_chara(Actor002,-90,0.35)
--アルハン、登場
PlayActionDirect(Actor003,"to Std_start")
wait_time(3.0)
　
-- ▲直接出力

	--★★アルハン★★:忘れてしまったのか
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130044")

-- ▼直接出力
setup_small_camera_start(CUT20)
-- ▲直接出力

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130046")

-- ▼直接出力
PlayPartVoiceDirect("アルハン","0009")
-- ▲直接出力

	--★★アルハン★★:…そうだ
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130047")

-- ▼直接出力
setup_small_camera_start(CUT21)
-- ▲直接出力

	--★★アルハン★★:<%player>
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130048")


	--★★アルハン★★:キサマは過去へと潜行し<br>３つの分岐世界を体験した
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130049")


	--★★アルハン★★:ギネヴィア、ランスロット、ディナタン…<br>三者それぞれを<ruby=アロンダイト>武器</ruby>とする人生を
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130050")


	--★★アルハン★★:そのせいでキサマの心身には<br>多大な消耗がみられるのだ
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130052")

-- ▼直接出力
setup_small_camera_start(CUT22)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130053")


	--★★アルハン★★:膨大な歴史の奔流を受けたことで<br>以前の記憶が押し流されてしまっている…
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130054")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0029")
-- ▲直接出力

	--★★レーヴァテイン★★:き、記憶が、押し流されたって──
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130055")

	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130056")

	change_face(Actor003,"Sad")

	--★★アルハン★★:………恐らくは
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130057")

-- ▼直接出力
setup_small_camera_start(CUT14)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","EA_010_0130059")
	if is_select(1) then
		goto Block4_1
	end

::Block4_1::
	CloseTalkWindow()
	change_face(Actor002,"Sad")

	--★★Player★★:（それ以前も、それ以降も<br>思い出せない…）
	Talk(Actor002,"PLAYERNAME_GENDAI","mind","L","EA_010_0130061")

	goto Block4end

::Block4end::
-- ▼直接出力
setup_small_camera_start(CUT19)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アルハン★★:<ruby=ノワール>過去の継承者</ruby>の記憶は<br>近いうちに思い出すであろう
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130062")


	--★★アルハン★★:それは『最後の継承者』の因子と<br>紐づいているのだからな
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130064")

	change_face(Actor003,"Sad")

	--★★アルハン★★:だが<br>潜行以前の記憶は──
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130065")

	change_face(Actor003,"Normal")

	--★★アルハン★★:<%player>が<br>レーヴァテインと出会う以前の記憶は──
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130066")

-- ▼直接出力
setup_small_camera_start(CUT20)
-- ▲直接出力

	--★★アルハン★★:欠損し、消えたと見える
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130067")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
PlayActionDirect(Actor001,"to  Std_No")
wait_time(1.7)
--レーヴァテイン振り向き
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,70,0.35)
wait_time(0.35)
PlayActionDirect(Actor001,"to Std_Loop")
setup_small_camera_start(CUT22)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0024")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★レーヴァテイン★★:…──欠損、って…そんな
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130070")


	--★★アルハン★★:<%player>が<br>数多の武器を得た代償として
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130071")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0040")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:だめ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130073")

-- ▼直接出力
setup_small_camera_start(CUT23)
-- ▲直接出力

	--★★アルハン★★:レーヴァテイン
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130074")

-- ▼直接出力
CloseTalkWindow()
--レーヴァ振り向き
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,0,0.35)
wait_time(0.35)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:だ、だめ、だめだよ。アルハン…っ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130075")


	--★★レーヴァテイン★★:あ、アルハン…！<br>私…そんなの聞いてない！
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130077")

-- ▼直接出力
PlayPartVoiceDirect("アルハン","0032")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★アルハン★★:
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130078")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0016")
-- ▲直接出力

	--★★レーヴァテイン★★:だとしても納得できないよ！<br>それに、<dot>あの子</dot>も悲しむ………！
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130079")

	change_face(Actor003,"Sad")

	--★★アルハン★★:………
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130082")

-- ▼直接出力
setup_small_camera_start(CUT24)
    
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:…戻してよ<br>こんなの酷すぎる…
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130083")


	--★★レーヴァテイン★★:今までの…学園での思い出を<br>全部忘れたってことでしょ？
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130084")

	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:それ…知ってたら、私──…！！
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130085")

-- ▼直接出力
PlayPartVoiceDirect("アルハン","0040")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アルハン★★:だが<%player>が潜らねば<br>キサマも敗れていた、違うか？
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130086")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0043")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:それは…っ！ <br>そうかもしれないけど、でも─
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130087")


	--★★レーヴァテイン★★:私、<dot>また</dot>………ッ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130088")

-- ▼直接出力
CloseTalkWindow()
heroId = GetPlayerStyleId()
    local controllerName = GetE0010DownPlayerController(heroId)
set_animationcontroller(Actor002,controllerName, "to initial")
setup_small_camera_start(CUT25)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.85)
se_play("SE_ADV_MA_01B112_38_Kneeling")
--レーヴァ、振り向き時計回り90度
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,90,0.35)
wait_time(0.35)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0029")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★レーヴァテイン★★:え、<%player>！？
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130091")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT26)
 PlayActionDirect(Actor001,"to Wlk")
wait_time(0.3)
slidemove(Actor001,1.903, 0, 13.864, 1.0)
wait_time(1.35)

PlayActionDirect(Actor001,"to Sit10")
--[[◆レーヴァ、ちょっと歩く
移動先の配置：P202

◆レーヴァ、主人公のもとにしゃがむ
トリガー：to Sit10]]
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","EA_010_0130093")
	if is_select(1) then
		goto Block5_1
	end

::Block5_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
wait_time(1.35)
fadeout(0,0,0,0.2, 1.2)
wait_time(1.2 + 0.2)
show_image("101010140", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_scale_image(20,20)
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0021")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★アルハン★★:…！過去への潜行から戻ってすぐに戦った…<br>その負荷で意識が──…
	Talk(Actor003,"NPCNAME_0313","speech","L","EA_010_0130095")

	goto Block5end

::Block5end::
-- ▼直接出力
CloseTalkWindow()
wait_time(1.2)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0130098")

-- ▼直接出力
CloseTalkWindow()
on_cameraframe(2) 
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("201010160", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
wait_time(0.2)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:あのとき<br>私が迎えに行ったせいで
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","L","EA_010_0130100")


	--★★レーヴァテイン★★:あなたは自分の記憶を失って<br>他人の痛みを請け負うことになった
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","L","EA_010_0130101")


	--★★レーヴァテイン★★:戸惑うことなく<br>名前を教えてくれたあなたを──
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","L","EA_010_0130102")


	--★★レーヴァテイン★★:私が破滅させた
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","L","EA_010_0130103")


	--★★レーヴァテイン★★:ごめん…イヤ、だよね…<br>学生生活の記憶が消えるなんて
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","L","EA_010_0130104")


	--★★レーヴァテイン★★:一生の思い出として残る<br>大切な記憶もあったはずなのに
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","L","EA_010_0130105")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(0.2 + 0.2)
fadein(0.2)

on_cameraframe(2) 
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("201010170", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
wait_time(0.2)
-- ▲直接出力

	--★★レーヴァテイン★★:私は…その名の通り『<ruby=レーヴァテイン>破滅の剣</ruby>』
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","L","EA_010_0130106")


	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","L","EA_010_0130108")


	--★★レーヴァテイン★★:………でも
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","L","EA_010_0130109")


	--★★レーヴァテイン★★:でもね、<%player>
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","L","EA_010_0130110")


	--★★レーヴァテイン★★:救いようのない私は<br>あなたを救いたい
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","L","EA_010_0130111")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力

	--★★レーヴァテイン★★:どれだけ、もがいてでも 
	Talk(Actor001,"CHRNAME_LAEVATEIN","simple","L","EA_010_0130112")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
heroId = GetPlayerStyleId()
if heroId == 101003001 then
	heroIdshort = 101003
	Yof=1.6
elseif heroId == 101005001 then
	heroIdshort = 101005
	Yof=1.6
elseif heroId == 101007001 then
	heroIdshort = 101007
	Yof=1.6
elseif heroId == 101004001 then
	heroIdshort = 101004
	Yof=1.45
elseif heroId == 101006001 then
	heroIdshort = 101006
	Yof=1.45
else
	heroIdshort = 101008
	Yof=1.45
end
load_image_preload("201010160", "content_still_20101016_image", "201010160_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("201010170", "content_still_20101017_image", "201010170_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101220011)
	InitializeCharacter_3D_Preload("101002","001","101002001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation06)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

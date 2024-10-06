-- このluaスクリプトは、EA_010_021_2.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100011_02","100011_02_h")
Include("content_adv_advsmall_100011_02","Template100011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100011_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleName100011_02,CameraPos100011_02_002)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPos100011_02_011,CameraAssetBundleName100011_02,CameraPos100011_02_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos100011_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName100011_02,CameraPos100011_02_003)
	Camera004 = SetTemplate("Actor005",nil,CharaPos100011_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName100011_02,CameraPos100011_02_003)
	InitializeTemplateRandomCamera100011_02()
	InitializeTemplate100011_02()
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
　set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
CUT10 =  cat_template_camera("P10_Cam")
CUT11 =  cat_template_camera("P11_Cam", Actor002)
CUT12 =  cat_template_camera("P12_Cam")
CUT13 =  cat_template_camera("P13_Cam")
CUT14 =  cat_template_camera("P14_Cam")
CUT15 =  cat_template_camera("P15_Cam", Actor002)
CUT17 =  cat_template_camera("P17_Cam")
CUT18 =  cat_template_camera("P18_Cam")
CUT19 =  cat_template_camera("P19_Cam")
CUT20 =  cat_template_camera("P20_Cam")
CUT21 =  cat_template_camera("P21_Cam", Actor002)
CUT23 =  cat_template_camera("P23_Cam")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
Hide(Actor005)
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("201010154", "content_still_20101015_image", "201010154_StillImage")
load_image("101050170", "content_still_10105017_image", "101050170_StillImage")
load_image("101050180", "content_still_10105018_image", "101050180_StillImage")
load_image("101030140", "content_still_10103014_image", "101030140_StillImage")
load_image("101020130", "content_still_10102013_image", "101020130_StillImage")
load_image("201010220", "content_still_20101022_image", "201010220_StillImage")
load_image("101050010", "content_still_10105001_image", "101050010_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Prison")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_LTeinn")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100011)
	Actor001 = InitializeCharacter_3D("101002","002","101002002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	Actor003 = InitializeCharacter_3D("101035","003","101035003","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_3D("101035","003","101035003","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_2DOnly("101002","002","101002002")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(CUT11)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0002")
-- ▲直接出力

	--★★？？？★★:
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","EA_010_0210011")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,310,0.35)
wait_time(0.35)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.5)
Appear(Actor005)
setup_small_camera_start(CUT12)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★小柄な少女★★:お、お、おはようございます
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210015")


	--★★小柄な少女★★:
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210016")

	open_select_window_tag(Actor002,"Normal","EA_010_0210018")
	if is_select(1) then
		goto Block1_1
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(CUT13)
PlayActionDirect(Actor002,"to  Std_Talk")
wait_time(2.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	goto Block1end

::Block1end::
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0007")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★小柄な少女★★:昨日は、お、お疲れ様でした
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210021")


	--★★小柄な少女★★:が、学園内のバルバロイ鎮圧のかたわら<br>窓からあなたを見て、イエ…拝見していました
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210022")

-- ▼直接出力
setup_small_camera_start(CUT14)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★小柄な少女★★:あの、数多の武器を操る雄姿…っ<br>過去の歴史なかでどれほど研鑽を積まれたのか…
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210023")


	--★★小柄な少女★★:
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0211001")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0009")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★小柄な少女★★:『最後の継承者』のお力…<br>さすがです、ハイ。さすがのお力…ですっ
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210024")

-- ▼直接出力
setup_small_camera_start(CUT10)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★小柄な少女★★:昨日は、あなたが昏倒されたあと…<br>わ、私たちで安全な場所へお運びしました
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210025")

	PlayAction(Actor005,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0023")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★小柄な少女★★:いえっ、変なことはしていません<br>断じて…断じてっ
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210026")

	change_face(Actor005,"Laugh")

	--★★小柄な少女★★:お目覚めになられて<br>本当に、本当に良かったと心から思います
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210027")

-- ▼直接出力
setup_small_camera_start(CUT15)
slidemove(Actor002,-1.337, 0, -4.895,3)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","EA_010_0210029","EA_010_0210030")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(CUT17)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0037")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★小柄な少女★★:ああっ、すみません…！
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210033")

	change_face(Actor005,"Surprise")

	--★★小柄な少女★★:同じ質問を二度もさせてしまって<br>すみ、すみま、すみません…っ
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210034")

	change_face(Actor005,"Sad")

	--★★小柄な少女★★:まずは歓迎のお言葉を、と思って<br>ああ、いえ、いえ、これは言い訳ですねハイ
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210035")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(CUT17)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0028")
-- ▲直接出力
	change_face(Actor005,"Shy")

	--★★小柄な少女★★:わ、わっ、私を…！？
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210038")

	change_face(Actor005,"Shy")

	--★★小柄な少女★★:こんなチンチクリンとお会いしました…？<br>わ、私は、ちょっと覚えがなく…！
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210039")

	change_face(Actor005,"Shy")

	--★★小柄な少女★★:
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210040")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start(CUT14)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0009")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★小柄な少女★★:な、なんにせよ<br>あの──…はじめまして
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210042")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Smile")

	--★★小柄な少女★★:六千年学園・継守会<br>ロンギヌスと申します
	Talk(Actor005,"NPCNAME_0399","speech","L","EA_010_0210044")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow() 
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
Hide(Actor005)
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Prison")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0002")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ロンギヌス★★:…記憶を失われて<br>ご混乱…されてます、よね？
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0210047")

	change_face(Actor003,"Normal")

	--★★ロンギヌス★★:不肖、私がご説明…します<br>今のあなたの状況を
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0210048")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(0.2 + 0.2)
show_image("201010154", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_scale_image(0.75,0.75)
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力

	--★★ロンギヌス★★:我々は六千年学園『継承者守護生徒会』<br>──略して、<ruby=けいしゅかい>継守会</ruby>
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210050")


	--★★ロンギヌス★★:「<ruby=あなた>最後の継承者</ruby>を守護し<br>ともにバルバロイを殲滅する」
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210052")


	--★★ロンギヌス★★:その<ruby=めい>命</ruby>を受けた者たちです
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210054")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(0.2 + 0.2)
show_image("101050170", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_scale_image(0.75,0.75)
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力

	--★★ロンギヌス★★:原初の時代、数多の時代──<br>人とバルバロイは戦いを繰り返してきました
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210057")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(0.2 + 0.2)
show_image("101050180", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_scale_image(0.75,0.75)
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力

	--★★ロンギヌス★★:その歴史を体験し、観測した武器を<br>己のものとして使える。それが『<ruby=あなた>最後の継承者</ruby>』
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210059")


	--★★ロンギヌス★★:
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210061")


	--★★ロンギヌス★★:無限に増え続けるバルバロイに対抗できるのは<br>その無尽の武器庫を有する<ruby=あなた>最後の継承者</ruby>だけです
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210062")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(1 + 0.2)
show_image("101030140", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_scale_image(0.75,0.75)
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力

	--★★ロンギヌス★★:過去に施されたバルバロイの封は<br>いまや衰えました
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210065")


	--★★ロンギヌス★★:現代にバルバロイが溢れ始めたのは<br>しばらく前のこと
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210066")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(0.2 + 0.2)
show_image("101020130", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_scale_image(0.75,0.75)
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力

	--★★ロンギヌス★★:人類の生存区域は<br>大幅に絞られました
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210068")


	--★★ロンギヌス★★:
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210069")


	--★★ロンギヌス★★:本格的な侵攻が始まったのは<br>………昨日のことです
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210070")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(0.2 + 0.2)
show_image("201010220", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_scale_image(0.75,0.75)
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力

	--★★ロンギヌス★★:ここは、六千年学園<br>あなたがこれまで通っていた学園です
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210073")


	--★★ロンギヌス★★:あなたはこの学園で『最後の継承者』としての<br>素質を見出された存在でした
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210074")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(1 + 0.2)
show_image("101050010", 0.0, 0.0, STILL_SWITCH_TIME ,true,true) --0.6秒
set_scale_image(0.75,0.75)
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力

	--★★ロンギヌス★★:ゆえに昨日<br>レーヴァテインがあなたを──
	Talk(Actor003,"CHRNAME_LONGINUS","simple","L","EA_010_0210076")

-- ▼直接出力
CloseTalkWindow() 
fadeout(0,0,0,0.2, 0.2)
wait_time(1 + 0.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(0.8 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0017")
-- ▲直接出力

	--★★レーヴァテイン２★★:ロンギヌス、やめて<br>もういいよ
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210077")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor001)
slidemove(Actor001,1.502, 0, -5.031,0.1)
setup_small_camera_start(CUT18)
CloseTalkWindow() 
hide_image(BLACK_WHITE_TIME)

PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,102,0.35)
wait_time(0.35)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(2.5)
setup_small_camera_start(CUT19)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210081")

	change_face(Actor003,"Sad")

	--★★ロンギヌス★★:
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0210082")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0041")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:ううん、私のせい<br>だから…
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210083")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT20)

PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,280,0.35)
wait_time(0.35)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:責任<br>取るから
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210085")


	--★★レーヴァテイン★★:あなたの記憶を奪った、責任
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210086")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
shake_camera(CUT20, 0.42, 3.5)
se_play("SE_ADV_MA_01A111_14_Earthquake")
se_play("SE_LoopSE_Stop")
wait_time(3.5)
setup_small_camera_start(CUT18)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_LTeinn")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ロンギヌス★★:…！『歪』…！？<br>バルバロイです、レーヴァテイン
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0210088")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:行こう、ロンギヌス
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210089")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:あと<%player><br>あなたはもう戦わないで
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210090")

-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0028")
-- ▲直接出力

	--★★ロンギヌス★★:
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0210091")

-- ▼直接出力
setup_small_camera_start(CUT21)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","EA_010_0210093","EA_010_0210094")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	end

::Block3_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(CUT23)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0040")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:…あのときは、知らなかったから<br>戦ってもらったけど………
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210097")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:過去に潜って得た力の…代償があったなんて<br>…それも、記憶が取り戻せないだなんて
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210098")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0002")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ロンギヌス★★:か、<ruby=ノワール>過去の継承者</ruby>の記憶は<br>いずれ思い出されるとのことですし──
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0210099")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★レーヴァテイン★★:…<%player>自身の記憶は<br>もう戻らないらしいよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210101")

	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:で…そのキッカケを作ったのは、私
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210102")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(CUT23)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0053")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:最終的には…そうだろうね
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210105")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:あなたは多くの戦士を従えられる<br>武器をひとつしか持たない私たちとは違って
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210106")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0002")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ロンギヌス★★:で、でしたらやはり<br>一緒に戦っていただくほうが…
	Talk(Actor003,"CHRNAME_LONGINUS","speech","L","EA_010_0210107")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:私が死んだら、好きにしていいよ
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210108")

	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:でも、それまでは──
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210109")

	goto Block3end

::Block3end::
-- ▼直接出力
setup_small_camera_start(CUT19)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★レーヴァテイン★★:私があなたを救う
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210111")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★レーヴァテイン★★:あなたを誰からも<br>傷つけさせない
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210112")

	change_face(Actor001,"Normal")

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210113")


	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210114")

-- ▼直接出力
CloseTalkWindow()
 PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,70,0.435)
wait_time(0.435)
slidemove(Actor001,6.502, 0, -4.665,3)
wait_time(3.35)
PlayActionDirect(Actor002,"to Std_Loop")
--画面外へ走り去る
Hide(Actor001)
setup_small_camera_start(CUT18)
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★レーヴァテイン２★★:あっち行って
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210116")


	--★★レーヴァテイン２★★:じゃないと、消すよ？
	Talk(Actor006,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210117")

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
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("201010154", "content_still_20101015_image", "201010154_StillImage")
load_image_preload("101050170", "content_still_10105017_image", "101050170_StillImage")
load_image_preload("101050180", "content_still_10105018_image", "101050180_StillImage")
load_image_preload("101030140", "content_still_10103014_image", "101030140_StillImage")
load_image_preload("101020130", "content_still_10102013_image", "101020130_StillImage")
load_image_preload("201010220", "content_still_20101022_image", "201010220_StillImage")
load_image_preload("101050010", "content_still_10105001_image", "101050010_StillImage")
preload_sound("BGM_ADV_Prison")
preload_sound("BGM_Battle_LTeinn")
	InitializeLoad_Preload()
	load_area_scene_preload(100011)
	InitializeCharacter_3D_Preload("101002","002","101002002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","003","101035003","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101035","003","101035003","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_2DOnly_Preload("101002","002","101002002")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName100011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

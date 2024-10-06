-- このluaスクリプトは、MA_01104_25.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",26,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera006 = SetTemplate("Actor006",-38,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("103010270", "content_still_10301027_image", "103010270_StillImage")
CameraEx = set_camera(1.273,2.268,8.045,11.44236,185.5585,0,21.50124)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002, Actor004, "J_Head")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Serious2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000012)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","002","101001002","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Talk")

	--★★ガウェイン★★:…だからさ<br>出しゃばられちゃ困るンだよ転校生
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_250002")

	open_select_window_tag(Actor001,"Normal","MA_01104_250003","MA_01104_250004","MA_01104_250005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアに助けられて<br>ここまでやっと来られたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_250007")

	change_face(Actor001,"Normal")

	--★★ノワール★★:出しゃばる余裕なんてなかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_250008")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ケイがガンコなだけだもんね<br>退学しろ～なんて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250009")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ノワールの雇い主は<br>わたしなのにね？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロットにも<br>なにか考えがあるみたいだったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_250012")

	change_face(Actor005,"Shy")

	--★★ラグネル★★:ノワールとランスロット先生…<br>もしかして、ただならぬ関係！？
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","MA_01104_250013")

	change_face(Actor004,"Normal")

	--★★ガウェイン★★:いーんだよ、ンなことは！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_250014")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンを待たせているんだ<br>出しゃばるつもりはないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_250016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:妹さんのためにも<br>無事帰らなきゃならないもんね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250017")

	change_face(Actor003,"Normal")

	--★★ギネマウア★★:成果はございましたね<br>謎も…増えましたが
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_250018")

	goto Block1end

::Block1end::
	change_face(Actor004,"Normal")

	--★★ガウェイン★★:これで転校生がろくな戦果も挙げず<br>そのうえ死んじまってみろ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_250020")


	--★★ガウェイン★★:「アーサー様がノリで色々決めちまったが<br>見込み外れだった」みてーになるだろ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_250021")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ノリで決めた感も否めないわね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ガウェイン★★:アーサー様のノリの願いも叶えて<br>殿下の無茶にもタダ働き
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_250023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
turn_chara(Actor002, -13,0.5)
-- ▲直接出力

	--★★ギネヴィア★★:しッつれいね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250024")

	change_face(Actor003,"Sad")

	--★★ギネマウア★★:返す言葉もございません
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_250025")

	change_face(Actor004,"Laugh")

	--★★ガウェイン★★:イイ度胸してるぜ<br>無茶振りばっかなのによ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_250026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:ま。俺はアーサー様に言われることなら<br>なんでもござれだけどな！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_250027")

	change_face(Actor005,"Sad")

	--★★ラグネル★★:ガウェイン…あんたの<br>アーサー様大好きマウンティングはいいのよ
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","MA_01104_250028")

	change_face(Actor004,"Laugh")

	--★★ガウェイン★★:しかもランスロットに喧嘩売ったってんだろ？<br>どんなメンタルしてんだよ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_250029")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Normal")

	--★★ノワール★★:置き去りにされたくないんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_250030")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ラグネル★★:置き去りって…誰に？
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","MA_01104_250031")

-- ▼直接出力
CloseTalkWindow()
shake_camera(Camera005, 0.5, 2.4)
se_play("SE_ADV_MA_01104_25_Earthquake")
se_play("SE_ADV_Emy001_Cry")
wait_time(1.0)
DontChangeRandomCamera(true)
on_camera(RndCamera090)
shake_camera(RndCamera090, 0.5, 6.0)
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Surprise")
change_face(Actor002,"Surprise")
change_face(Actor003,"Surprise")
change_face(Actor004,"Surprise")
change_face(Actor005,"Surprise")
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
show_image("103010270", 0.0, 0.0, STILL_SWITCH_TIME,true,true)
move_to_image(0,-150,3.5,"EaseOut")
wait_time(3.5)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Serious2")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:………キャメリアードが、揺れてる…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250033")

	open_select_window_tag(Actor001,"Normal","MA_01104_250034","MA_01104_250035")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME) --0.6秒
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER ) --0.6秒 + 0.8秒
DontChangeRandomCamera(false)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キャメリアードの国民は無事なんだよな？<br>きっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_250037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:決まってるじゃない、そんなの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250038")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:みんな無事よ<br>パパなんか前より太ってるかも
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250039")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力

CloseTalkWindow()
hide_image(STILL_SWITCH_TIME) --0.6秒
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER ) --0.6秒 + 0.8秒
DontChangeRandomCamera(false)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:キャメリアードの国民は、もう…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_250041")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:バカ言わないで
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250042")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:そうカンタンにやられるみんなじゃないわ<br>採掘作業でカラダ鍛えてるんだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250043")

	goto Block2end

::Block2end::
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…大丈夫よ<br>まだ覚えてるもの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250045")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:………パパ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250047")

	change_face(Actor003,"Anger")

	--★★ギネマウア★★:いけません殿下
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_250049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:いけるでしょ、ロンゴミアント
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250050")


	--★★ギネマウア★★:今は帰りましょう…！
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_250051")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:どこに帰るっていうのよ！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250052")

	change_face(Actor003,"Sad")

	--★★ギネマウア★★:殿下…！
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_250054")

-- ▼直接出力
setup_small_camera_start(Camera002)
set_animationbattlecontroller(Actor001, 1, false)
PlayActionDirect(Actor001,"ToAbnormal")
SkipDefaultMotion(Actor001)
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")

	--★★ギネヴィア★★:わたしたちの家は、すぐそこでしょ！？<br>わたしたちが帰るのは－－…！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250055")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:………ぐっ！？…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_250057")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Std_Loop")
fadeout(0,0,0,1.0, FADE_TIME_FAST)
se_play("SE_ADV_MA_01104_25_Fall")
wait_time(TIME_ELAPSED + FADE_TIME_FAST)
set_animationcontroller(Actor001,"Chr_002_03_MA01104_25_Controller","to Std_Loop")
set_animationcontroller(Actor006,"Chr_521_02_MA01104_25_Controller","to Std_Loop")
DontChangeRandomCamera(true)
on_camera(CameraEx)
set_pos(Actor006,{0.963,0,-0.189})
set_rot(Actor006,{0,277,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
lookWeight = {0.5, 0.07, 0.7, 0.35}
lookat_delay_weight(Actor002, lookWeight,100)
lookat_delay_weight(Actor003, lookWeight,100)
lookat_delay_weight(Actor004, lookWeight,100)
lookat_delay_weight(Actor005, lookWeight,100)
lookat_delay_weight(Actor006, lookWeight,100)
keep_ik_lookat(Actor002, nowaru_taore, "J_Head")
keep_ik_lookat(Actor003, nowaru_taore, "J_Head")
keep_ik_lookat(Actor004, nowaru_taore, "J_Head")
keep_ik_lookat(Actor005, nowaru_taore, "J_Head")
keep_ik_lookat(Actor006, nowaru_taore, "J_Head")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Surp")
PlayActionDirect(Actor002,"to  Std_Surp")
PlayActionDirect(Actor003,"to  Std_Surp")
PlayActionDirect(Actor005,"to  Std_Surp")
reserve_eyesync(Actor001,"Close")
fadein(FADE_TIME_FAST)
wait_time(FADE_TIME_FAST + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
turn_chara(Actor002,55,0.5)
 -- turn_chara(Actor006,27,0.5)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ガウェイン★★:お、おい、転校生！？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01104_250059")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ノワール！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250060")

-- ▼直接出力
lookat_delay_weight_reset(Actor002 , 1)
 lookat_delay_weight_reset(Actor003 , 1)
 lookat_delay_weight_reset(Actor004 , 1)
 lookat_delay_weight_reset(Actor005 , 1)
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ティルフィング★★:………申し訳ありません<br>マスターを休ませて、頂けますか
	Talk(Actor006,"CHRNAME_TYRFING","speech","L","MA_01104_250061")


	--★★ギネヴィア★★:…あなたの、せい…！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250062")

	change_face(Actor006,"Normal")

	--★★ティルフィング★★:…継承者の目覚めには<br>大きな反動があるのです
	Talk(Actor006,"CHRNAME_TYRFING","speech","L","MA_01104_250063")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ギネヴィア★★:キャメリアードの土地も<br>あなたがこうやって力を吸い取ったの…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250064")

	change_face(Actor006,"Sad")

	--★★ティルフィング★★:………
	Talk(Actor006,"CHRNAME_TYRFING","speech","L","MA_01104_250065")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:殿下…戦い続きです<br>どうかご自愛を──
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_250066")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:わたしが弱っちいから？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250067")

	change_face(Actor003,"Sad")

	--★★ギネマウア★★:殿下………
	Talk(Actor003,"NPCNAME_0070","speech","L","MA_01104_250068")


	--★★ギネヴィア★★:………ねえノワール	
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250070")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★ギネヴィア★★:本当のこと言ってくれないね<br>だあれも
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_250072")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103010270", "content_still_10301027_image", "103010270_StillImage")
preload_sound("BGM_ADV_Serious2")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000012)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","002","101001002","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

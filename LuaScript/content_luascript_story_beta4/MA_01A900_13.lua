-- このluaスクリプトは、MA_01A900_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_009)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_007)
	Camera005 = SetTemplate("Actor006",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera006 = SetTemplate("Actor007",nil,CharaPos110141_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_008)
	Camera007 = SetTemplate("Actor009",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera008 = SetTemplate("Actor010",nil,CharaPos110141_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_006)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10103010_anim", "10103010_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
-- ▼直接出力
load_image("10302009", "content_still_10302009_image", "103020090_StillImage")
load_image("10302010", "content_still_10302010_image", "103020100_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("10302009", 0.0, 0.0, 0)
-- ▲直接出力
-- ▼直接出力
set_scale_image(1.25,1.25)
set_position_image(250,50)
move_to_image(-250,50,10.0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor003,false)
set_enable_auto_lookat(Actor004,false)
set_enable_auto_lookat(Actor005,false)
set_enable_auto_lookat(Actor006,false)
set_enable_auto_lookat(Actor007,false)
set_enable_auto_lookat(Actor008,false)
set_enable_auto_lookat(Actor009,false)
set_enable_auto_lookat(Actor010,false)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor003,Actor002)
set_common_look_at(Actor004,Actor002)
set_common_look_at(Actor005,Actor002)
set_common_look_at(Actor006,Actor002)
set_common_look_at(Actor007,Actor002)
set_common_look_at(Actor008,Actor002)
set_common_look_at(Actor009,Actor002)
set_common_look_at(Actor010,Actor002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,0.8,0.03,0.8,0.2)
keep_delay_ik_lookat(Actor002,Actor009, "J_Head", 0.7)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_2DOnly("101014","001","101014001")
	Actor006 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_2DOnly("101019","001","101019001")
	Actor009 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_2DOnly("101012","001","101012001")
	Actor012 = InitializeCharacter_2DOnly("101017","001","101017001")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(2.5)
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
wait_time(1.5)
show_image("101010140", 0.0, 0.0, 0)
fadein(0.5)
-- ▲直接出力

	--★★ギネヴィア★★:…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A900_130002")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,0.5)
wait_time(0.5)
	stillAnime.SetActive(true)
	hide_image(0)
	fadein(0.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Surprise")

	--★★ギネヴィア★★:のっ、のっ、のわ、のわーる…？<br>それに、えっ、えええ、えええええ…？
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_130004")

	close_cutin()
	open_select_window_tag(Actor001,"Normal","MA_01A900_130006","MA_01A900_130007","MA_01A900_130008")
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
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:おはよう
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01A900_130010")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:お、お、おは、おはよう…？
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_130011")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:まだ夜か
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01A900_130012")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:そう、ええ、そうよ！<br>だから驚いてるんだけど！？
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_130013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:体調は戻った？
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01A900_130015")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:若干寝ぼけてるくらいで<br>ぜ、ぜんっぜんへーきだけど…？
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_130016")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ていうかなによこれ…！
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_130017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:おやすみ
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01A900_130019")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:おやすみ？
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_130020")

	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:オォイ！寝るな！解説して！オイ！
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_130022")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力

	--★★ギネマウア★★:…ずいぶん、お寝坊さんね
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","simple","N","MA_01A900_130024")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:お、お姉ちゃん…？これ、どういうこと…？<br>みんな、どうしてこんなとこで寝てるの…？
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_130025")

	change_face(Actor006,"Smile")

	--★★ギネマウア★★:いつ起きても寂しくないように<br>だそうですよ
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","simple","N","MA_01A900_130026")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力

	--★★ギネヴィア★★:わたしが倒れてから、ずっと？
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_130027")

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★エレイン★★:…ずっと、です
	Talk(Actor009,"CHRNAME_ELAINE","simple","N","MA_01A900_130029")


	--★★ギネヴィア★★:ゆ、床で？
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_130030")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力

	--★★ディナタン★★:遠征に行けば野宿もするし
	Talk(Actor011,"CHRNAME_DINATAN","simple","N","MA_01A900_130032")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "喜び")
-- ▲直接出力
	change_face(Actor012,"Smile")

	--★★マルディサント★★:ヨユーじゃね？
	Talk(Actor012,"CHRNAME_MALADISANT","simple","N","MA_01A900_130034")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:俺カタいとこのほうが<br>寝やすいんだよな～
	Talk(Actor004,"CHRNAME_GAWAIN","simple","N","MA_01A900_130036")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ラグネル★★:あ～、うん<br>わかるー
	Talk(Actor007,"CHRNAME_RAGNAR","simple","N","MA_01A900_130038")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ランスロット★★:みんな<br>もう遅いから寝ろ
	Talk(Actor003,"CHRNAME_LANCELOT","simple","N","MA_01A900_130040")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力

	--★★ギネヴィア★★:まだしゃべってるでしょうが
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_130041")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力

	--★★トリスタン★★:あ。起きたんだ<br>じゃあボク帰るね
	Talk(Actor005,"CHRNAME_TRISTAN","simple","N","MA_01A900_130043")

-- ▼直接出力
 --PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:廊下は冷えるわね
	Talk(Actor008,"CHRNAME_ISOLDE","simple","N","MA_01A900_130044")

-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力
	change_face(Actor010,"Smile")

	--★★ラヴェイン★★:エレインが言い出しっぺでして
	Talk(Actor010,"CHRNAME_LOVEIN","simple","N","MA_01A900_130046")

-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力

	--★★エレイン★★:ギネヴィアさんと<br>一緒にいたいんです、みんな
	Talk(Actor009,"CHRNAME_ELAINE","simple","N","MA_01A900_130047")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ギネヴィアと<br>少しでも長い時間、出来るかぎりたくさん
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01A900_130048")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…一緒に、いてくれるの？
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01A900_130049")

-- ▼直接出力
	CloseTalkWindow()
	signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end
fadeout(0, 0, 0, 0, STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME)
stillAnime.SetActive(false)
fadein(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力

	--★★ガウェイン★★:ギネヴィア<br>夜食、食いにいかね？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A900_130050")

	PlayAction(Actor007,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "肯定3")
-- ▲直接出力

	--★★ラグネル★★:明日、城下町でお買い物しようよ<br>ギネヴィア
	Talk(Actor007,"CHRNAME_RAGNAR","speech","L","MA_01A900_130051")


	--★★ギネヴィア★★:一緒にごはん食べてくれるの？<br>一緒に遊んでくれるの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_130052")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力

	--★★ギネマウア★★:なにをなさりたいですか、ギネヴィア様？
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A900_130053")

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:聞かせて。ギネヴィアさん
	Talk(Actor009,"CHRNAME_ELAINE","speech","L","MA_01A900_130054")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:………おはなし、聞きに来てくれたの…？？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_130055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:…あ、りが、とうっ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_130057")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ありが、と、うっ、ううっ、ありがとううう…っ<br>みんなああっ、うっ、ああああああああああああ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_130059")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Shy")

	--★★ギネヴィア★★:ただぁ、これはぁ、乙女のぷらいべえと的に<br>ちょっと、どうなんだろおおおお…？？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A900_130061")

	close_cutin()
	PlayAction(Actor009,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:そのあたりの私生活部分は<br>ギネマウアさんと私でなんとかしてますからっ
	Talk(Actor009,"CHRNAME_ELAINE","speech","L","MA_01A900_130062")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ずびずび…ん、あれ、これって<br>みんなの口ぶりから言って、もしかして…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_130063")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
	change_face(Actor009,"Normal")

	--★★エレイン★★:あ、聖域化のことですか？<br>信用できる人にしか話せないと仰せだったので…
	Talk(Actor009,"CHRNAME_ELAINE","speech","L","MA_01A900_130064")

	PlayAction(Actor009,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★エレイン★★:バラしちゃいました
	Talk(Actor009,"CHRNAME_ELAINE","speech","L","MA_01A900_130066")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:………おしゃべり！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_130067")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
fadeout(255,255,255,1.0, STILL_SWITCH_TIME)
se_play("SE_ADV_MA_01A900_13_Amb_Morning")
wait_time(STILL_SWITCH_TIME)
show_image("10302010", 0.0, 0.0,0)
show_image("10302010", 0.0, 0.0,0)
set_scale_image(1.15,1.15)
set_position_image(-100,-125)
move_to_image(100,-125,5)
fadein(STILL_SWITCH_TIME)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:（捨てたもんじゃない）
	Talk(Actor002,"CHRNAME_GUINEVERE","mind","L","MA_01A900_130069")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:（まだ、捨てたもんじゃないよね）
	Talk(Actor002,"CHRNAME_GUINEVERE","mind","L","MA_01A900_130070")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME)
hide_image(0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_ui_effect_preload("content_still_10103010_anim", "10103010_StillAnim", nil, nil, nil, "Root")
load_image_preload("10302009", "content_still_10302009_image", "103020090_StillImage")
load_image_preload("10302010", "content_still_10302010_image", "103020100_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101014","001","101014001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_2DOnly_Preload("101019","001","101019001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_2DOnly_Preload("101012","001","101012001")
	InitializeCharacter_2DOnly_Preload("101017","001","101017001")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

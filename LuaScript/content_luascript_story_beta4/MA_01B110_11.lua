-- このluaスクリプトは、MA_01B110_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-80,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",-55,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera005 = SetTemplate("Actor005",70,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
CameraEx1 = set_camera({-1.05,1.48,0.23,-3.83,-111,0,30.35})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor003,true)
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor004,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_2DOnly("101026","001","101026001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★パーシヴァル★★:いーやーだーね！！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110002")

-- ▼直接出力
 --PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:夜露に濡れて<br>草のベッドでお眠りになりますか？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_110003")

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Anger")

	--★★パーシヴァル★★:野宿全般お断りだよ！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","N","MA_01B110_110004")

	close_cutin()
-- ▼直接出力
setup_small_camera_start()
change_face(Actor002,"Normal")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★フィエナ★★:わがままだなあ
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B110_110005")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力

	--★★パーシヴァル★★:誰のせいでここまで来たと思ってるんだ！？
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110006")

	PlayAction(Actor001,"to  Std_Surp")

	--★★フィエナ★★:ウッ
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B110_110007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor004,"Normal","MA_01B110_110008","MA_01B110_110009","MA_01B110_110010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:パーシヴァルが<br>ひとりで帰るという手もある
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_110012")

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Anger")

	--★★パーシヴァル★★:ここんな夜道をひとりで行けっていうのかい！？<br>こここんな夜道を！！ひとりで行けって！？
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","N","MA_01B110_110013")

	close_cutin()
-- ▼直接出力
DontChangeRandomCamera(false)
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フィエナ★★:２回言った…<br>暗いの怖いんだ…
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B110_110014")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Anger")

	--★★パーシヴァル★★:夜は危険がいっぱい！！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:ガラハッドが先走らなくても<br>どのみち探索には出なければならなかった
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_110017")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★パーシヴァル★★:ウッ
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110018")

	change_face(Actor004,"Normal")

	--★★ノワール★★:予定が前倒しになっただけだ<br>野宿だっていつかはしなきゃいけなかったはずだ
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_110019")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フィエナ★★:そ、そーだそーだ！<br>私が言えた義理じゃないけど、そーだそーだ！
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B110_110020")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★パーシヴァル★★:ギー！ちゃんとした遠征の予定が立っていれば<br>こちらだって野宿の準備だってしたさ！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110021")

	change_face(Actor003,"Anger")

	--★★パーシヴァル★★:折りたたみのベッドとか！持ってきたさ！<br>それをぉぉ
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110022")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:私は運びませんよ。パー坊
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_110023")

	open_cutin(1,1)
	on_cutin(1,Actor003,"Pain")

	--★★パーシヴァル★★:ギー！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","N","MA_01B110_110024")

	close_cutin()
	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力

set_enable_auto_lookat_all(true)
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ノワール★★:高貴な人間には耐えがたいか<br>俺たちは全然平気なんだけどなあ
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_110026")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★パーシヴァル★★:ハァッッ！？
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110027")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
turn_chara(Actor001,-45,0.5)
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★フィエナ★★:ああ～、ねえ～、私もコルベニックの姫だけど<br>この程度の野宿は屁でもないんだけどなあ～
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B110_110028")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,10,0.5)
 --PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:私もパーシヴァル様と同様の出自ですが<br>野宿ごとき余裕でこなせますねえ
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_110029")

	open_cutin(1,2)
	on_cutin(1,Actor003,"Anger")

	--★★パーシヴァル★★:ど、同調圧力！！卑怯だ！！<br>個人の意思を尊重しないやりかただ！！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","N","MA_01B110_110030")

	close_cutin()
	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
change_face(Actor004,"Normal")
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.5)
PlayActionDirect(Actor001,"to Std_Loop")
turn_chara(Actor001,-80,1)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.5)
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor002,-55,1)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "激怒")
-- ▲直接出力

	--★★パーシヴァル★★:いーさ！その代わりボクの高貴な寝顔を<br>見せる気はないからね！！下賤な民たちにはっ！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110032")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(true)
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フィエナ★★:私、結構高貴な身分だけど
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B110_110034")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:確かに
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_110035")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力

	--★★パーシヴァル★★:うるさい！！ボクはひとりで寝るからな！<br>誰も来るんじゃないぞ！！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110036")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
turn(Actor003,0,-90,0,0.5)
slidemove(Actor003,{-4.3,0,0.5},2)
wait_time(3)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
Hide(Actor003)
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★パーシヴァル2D★★:ウワーーーーーー！
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110038")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フィエナ★★:うるさいなあ、いちいち
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B110_110039")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
change_face(Actor003,"Normal")
change_face(Actor004,"Normal")
-- ▲直接出力

	--★★パーシヴァル2D★★:人がいるー！！
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110040")

-- ▼直接出力
change_face(Actor001,"Surprise")
change_face(Actor002,"Surprise")
change_face(Actor004,"Surprise")
-- ▲直接出力

	--★★モーロノエー★★:騎士様…お、お助けを…
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","MA_01B110_110042")

	change_face(Actor006,"Sad")

	--★★パーシヴァル2D★★:た、助けて欲しいのはコッチだよ！<br>びっくりしたなーもー！
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110043")

-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Worry")
change_face(Actor004,"Normal")
-- ▲直接出力

	--★★モーロノエー★★:化け物に追われて、ひ、必死にここまで…！<br>外に出ようにも恐ろしくて、出られず…っ
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","MA_01B110_110044")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★パーシヴァル2D★★:…フッ、ボクに助けを求めるとは良い心がけだね<br>婦人の望みを叶えるのも高貴なる者の務めだ
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110045")


	--★★モーロノエー★★:そ、それでは夜が明けるまでおそばに…<br>寄り添っていていただけますか、騎士様…？
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","MA_01B110_110046")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
change_face(Actor002,"Sad")
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力

	--★★パーシヴァル2D★★:ええっ！？ええ～っ！？そっ、そんな<br>えー、そんなそんなあ～！？
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110048")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
 --PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フィエナ★★:なに、このトントン拍子感…<br>あの人…都合良すぎるんじゃない？
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B110_110049")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	open_select_window_tag(Actor004,"Normal","MA_01B110_110050","MA_01B110_110051","MA_01B110_110052")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	change_face(Actor004,"Normal")

	--★★ノワール★★:どうして騎士だとわかった？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_110054")

	change_face(Actor005,"Normal")

	--★★モーロノエー★★:………え？
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","MA_01B110_110055")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ノワール★★:この暗闇で<br>どうしてパーシヴァルが騎士だと？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_110056")

	change_face(Actor005,"Normal")

	--★★モーロノエー★★:こ、言葉遣いですとか<br>雰囲気ですとか
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","MA_01B110_110057")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ノワール★★:そんなに迷いなく<br>騎士だと断定できるものか？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_110058")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Normal")

	--★★ノワール★★:パーシヴァル、戻ってこい
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_110060")

	change_face(Actor006,"Anger")

	--★★パーシヴァル2D★★:指図するな！！
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110061")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フィエナ★★:わあ、なんというか<br>言い寄られて舞い上がってるなあ
	Talk(Actor001,"CHRNAME_VIENA","speech","L","MA_01B110_110062")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★パーシヴァル2D★★:この人の気持ちに寄り添っているだけさ！<br>高貴なる者の務めとして！！
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110063")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
 --PlayPartVoice("ディンドラン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディンドラン★★:あの子のこんな姿は<br>こんなところで見たくなかったですね…
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_110064")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ノワール★★:おやすみ、パーシヴァル
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01B110_110066")

	change_face(Actor006,"Smile")

	--★★パーシヴァル2D★★:おやすみ！！
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110067")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★パーシヴァル2D★★:野宿もたまにはいいもんだなあ！<br>いやあ、悪くない悪くない！
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110068")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
 --PlayPartVoice("ディンドラン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディンドラン★★:パー坊…
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_110069")

	goto Block2end

::Block2end::
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★パーシヴァル2D★★:では名も知らぬキミ？<br>キミはボクの仲間のもとへ行くんだ
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110071")

	change_face(Actor005,"Normal")

	--★★モーロノエー★★:え？
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","MA_01B110_110072")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★パーシヴァル2D★★:同性がいた方が安心だろう？<br>ボクの姉は優しいんだ、寄り添って寝てくれるよ
	Talk(Actor006,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110074")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
set_rot(Actor003,{0,90,0})
change_face(Actor003,"Smile")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディンドラン★★:…パー坊
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_110076")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{-1.1,0,0.5},2)
wait_time(1.8)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★パーシヴァル★★:悪いね。面倒かけるけど、この人と──
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_110077")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, 0.3,false,false)
set_scale_image(20,20)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
lookat_weight_reset(Actor005)
setup_small_camera_start(Camera003)
 --PlayPartVoice("モーロノエー", "笑い")
-- ▲直接出力

	--★★モーロノエー★★:………お眠りになります？
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","MA_01B110_110078")

-- ▼直接出力
CloseTalkWindow()
hide_image(0.3)
wait_time(2)
on_camera(CameraEx1)
on_active(FX_DoF)
-- ▲直接出力
	PlayAction(Actor005,"to Greet_one")
-- ▼直接出力
--モーロノエー,CHRNAME_SISTERS_1 @名前変更
 --PlayPartVoice("モーロノエー", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★モーロノエー★★:ねえ？騎士様？
	Talk(Actor005,"CHRNAME_SISTERS_1","speech","R","MA_01B110_110080")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor003,"Surprise")

	--★★パーシヴァル★★:ウーーーーーーーーーーーワ、魔女じゃん
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","N","MA_01B110_110081")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_2DOnly_Preload("101026","001","101026001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

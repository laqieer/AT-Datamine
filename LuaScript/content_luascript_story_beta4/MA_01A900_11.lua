-- このluaスクリプトは、MA_01A900_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
Include("content_adv_advsmall_110061_03","110061_03_h")
Include("content_adv_advsmall_110061_03","Template110061_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera002 = SetTemplate("Actor002",127.5,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
load_image("103020060", "content_still_10302006_image", "103020060_StillImage")
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1.5)
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_003)
	InitializeTemplateRandomCamera110061_03()
	InitializeTemplate110061_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
set_common_look_at(Actor002,Actor001)
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:キャメリアードの王女を<br>娶るとき
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110002")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,35,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
set_common_look_at(Actor002,Actor001)
set_enable_auto_lookat(Actor001,true)
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_110004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:決して彼女を幸せにしないと決めた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110005")


	--★★アーサー★★:煌びやかなドレスをボロ布のように引きずり<br>真っ赤な瞳を濁らせて、彼女はやってきた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110006")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:当時の彼女は飾って高飛車だった<br>ここに居場所を見出す気すらなさげだった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110008")


	--★★アーサー★★:母国が攻め入られた彼女ら姉妹を守るために<br>キャメリアード王の望みで婚姻を結んだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:騎士王の膝元が最も安全なはずと懇願された
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:あそこには恩義もあった<br>断る理由はなかった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110012")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103020060", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:だがギネヴィアは「大アリよ」と怒った
	Talk(Actor002,"CHRNAME_ARTHUR","simple","N","MA_01A900_110015")


	--★★アーサー★★:当然だ<br>母国の侵略を契機に幸せな結婚生活など望めない
	Talk(Actor002,"CHRNAME_ARTHUR","simple","N","MA_01A900_110016")


	--★★アーサー★★:ギネヴィアは飾って周囲を遠ざけた<br>父の代わりに幸せになるわけにはいかないと
	Talk(Actor002,"CHRNAME_ARTHUR","simple","N","MA_01A900_110017")


	--★★アーサー★★:その瞳を金色に輝かせたのは<br>お前が来てからだ
	Talk(Actor002,"CHRNAME_ARTHUR","simple","N","MA_01A900_110018")


	--★★アーサー★★:王妃という飾りも継承者の劔という責務も<br>彼女はまっとうしようと強がり、結果すり減った
	Talk(Actor002,"CHRNAME_ARTHUR","simple","N","MA_01A900_110019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
--エフェクト終了
hide_image()
--スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A900_110021","MA_01A900_110022")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:王妃にしては活発過ぎたような
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_110024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:確かにな<br>だがあの立場を降りはしなかった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110026")

	change_face(Actor002,"Normal")

	--★★アーサー★★:彼女が前線に立つことが<br>士気にもつながった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:継承者の劔としては<br>頑張り過ぎだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_110029")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:たしかにここ数ヶ月は<br>負担の大きい戦いが続き過ぎた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110030")

	change_face(Actor002,"Smile")

	--★★アーサー★★:ルーシャスには対価を払ってもらわなければな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110031")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
wait_time(1.0)
template2()
  manager.CloseupUpExclusiveCamera(Actor002)
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
-- ▲直接出力
-- ▼直接出力
 --あわせてアーサーも向きを変える
turn(Actor002,0,51.5, 0,0.0)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:…たとえはよろしくないかもしれないが<br>お前はギネヴィアの器のようなものなのだろう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110034")

-- ▼直接出力
 --ノワールにカメラを向けて向きを変える
  manager.CloseupUpExclusiveCamera(Actor001)
PlayActionDirect(Actor001,"to Wlk")
turn(Actor001,0, -37.5, 0,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うつわ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_110035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:ギネヴィアは自分の器以上の無理を<br>ずっとし続けていたように見えた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110036")

	change_face(Actor002,"Normal")

	--★★アーサー★★:お前はそれを受け止めてくれた<br>王妃でも継承者の劔でもなく、友達として
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110037")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★アーサー★★:泣くことも、笑うことも出来るようになった<br>それはお前がいてくれたからだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:礼を言う
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110039")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…図書院のどこを調べても<br>彼女を救う方法が見つけられない…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_110041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:俺は彼女になにもしてあげられていない<br>戦いに連れ出したこと以外、なにも…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_110042")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ノワール★★:聖遺物化や聖域化なしに<br>バルバロイを止める方法はないのか…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_110043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:書物漁りは誰かとやらんと気が滅入る<br>もう少し付き合ってくれるか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110044")

-- ▼直接出力
set_enable_auto_lookat_all(false)
lookat_delay_weight_reset(Actor001 , 0.6)
lookat_delay_weight_reset(Actor002 , 0.6)
-- ▲直接出力

	--★★アーサー★★:飽きるほど読んだんだが<br>見落としがあるかもしれんしな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110045")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:読んだ？<br>ぜ、全部？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_110046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")

	--★★アーサー★★:大図書院は俺の書斎みたいなものだからな<br>倉庫にはこの5倍以上蔵書がある！自慢だが！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","N","MA_01A900_110047")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A900_110049","MA_01A900_110050")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:全部がアーサーの本？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_110052")

-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:父親から受け継いだものもあるがな<br>大半は俺が蒐集した。大変だった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110053")

	change_face(Actor002,"Smile")

	--★★アーサー★★:今は生徒たちの物だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110054")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
lookat_delay_weight_default(Actor001, 1)
keep_ik_lookat(Actor001,Actor002, "J_Head")
set_enable_auto_lookat_all(true)
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:継承者のキラーズを救う方法を、ずっと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_110056")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:学長だからな<br>これでも一応
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110058")

	change_face(Actor002,"Normal")

	--★★アーサー★★:公務の暇をぬって集めるのは骨が折れた<br>義兄さんや義姉さんには呆れられたよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110059")

	goto Block2end

::Block2end::
	change_face(Actor002,"Sad")

	--★★アーサー★★:だが、探しても探しても見つからないんだ<br>バルバロイを止める方法が──
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110061")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:継承者の劔を犠牲にするしか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110062")

	open_select_window_tag(Actor001,"Normal","MA_01A900_110064","MA_01A900_110065")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	end

::Block3_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:そう言われたって<br>諦め切れるものじゃない…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_110067")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:俺もだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110068")

	change_face(Actor002,"Normal")

	--★★アーサー★★:ギネヴィアのためだけじゃない<br>これまでのノワールの戦いに報いたい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110069")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:学園の皆がそう思っている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110070")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…諦めざるを、得ないのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_110072")

	change_face(Actor002,"Smile")

	--★★アーサー★★:諦めの悪さの結果が<br>この大図書院を作ったんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110073")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "否定")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★アーサー★★:そう簡単に投げ出せるものじゃないよな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_110074")

	goto Block3end

::Block3end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103020060", "content_still_10302006_image", "103020060_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest(CameraAssetBundleName110061_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

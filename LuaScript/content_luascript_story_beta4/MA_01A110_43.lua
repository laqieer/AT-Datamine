-- このluaスクリプトは、MA_01A110_43.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110251_31","110251_31_h")
Include("content_adv_advsmall_110251_31","Template110251_31_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110251_31_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110251_31,CameraPos110251_31_002)
	Camera002 = SetTemplate("Actor002",180,CharaPos110251_31_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110251_31,CameraPos110251_31_001)
	InitializeTemplateRandomCamera110251_31()
	InitializeTemplate110251_31()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001, {2.945,1.21,18.724})
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102023)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115254)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:「あなたが隣にいる。それだけでこの困難も<br>たやすく乗り越えていける気がします」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430002")

	change_face(Actor002,"Normal")

	--★★エレイン★★:「ひとつ誓いを立ててもらえますか？」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:………
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430004")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:恥ずかしい、恥ずかしくない、恥さらし<br>初めて、始めて、ハズせない、恥ずかしい──…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430005")


	--★★エレイン★★:あああああ～～～～…っ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430006")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:助けてぇ………
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430008")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
Appear(Actor001)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{0.8,1.21, 18.724}, 2)
wait_time(2.0)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.5)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:「なんなりと」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_430010")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,110,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:…！？先輩…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430011")


	--★★ノワール★★:こんな遅くまで…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_430012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Shy")

	--★★エレイン★★:か、陰なる努力…<br>見つかっちゃいましたね…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A110_430015","MA_01A110_430016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:言ってくれれば<br>練習なんていくらでも付き合うのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_430018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:そんな！！恥ずかしい！！<br>先輩の前でそんな
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430019")

-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:恥ずかしいって…<br>本番はもっとたくさんの人が見るよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_430020")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:そ、それはそうなんですけど…<br>でも、やっぱり恥ずかしくて…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:もしかして、本当は嫌だった？<br>芝居の主役なんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_430023")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめん。俺が推薦したせいで…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_430024")

-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:あ、謝らないでください！！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430025")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:確かに、人前に立ってなにかするのとか<br>本当はちょっと…いえ、だいぶ苦手で
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430026")

	change_face(Actor002,"Normal")

	--★★エレイン★★:隠れて、支えて、その方が性に合うし<br>本来であれば裏方に徹したかったですけど…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エレイン★★:でも、頑張ると決めたのは私なので…！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430028")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…演出家が言ってた「自分しか持ってないモノ」<br>ってわかったのか？そういえば
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_430030")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:はい。私の恥です
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:恥…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_430033")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight_reset(Actor002 , 0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,180,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★エレイン★★:ギネヴィア様は、スゴいですね<br>あんな大勢の前で演説までされて──
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:私はうまく、いきません…<br>デキるフリさえ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430036")

-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:デキるフリって…なんでそんなこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_430037")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,110,0.5)
wait_time(0.5)
set_enable_auto_lookat_all(true)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:…先輩のせいなんですよ<br>諦めきれないのは
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺の？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_430040")

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:期待に応えられない自分が嫌で<br>出て行けるような場所もない
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:…外では多くの人が活躍していて<br>それもうまくいかずに敗れていく…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430042")


	--★★エレイン★★:兄を<ruby=ゲシュタルト・シフト>ＧＳ</ruby>したにもかかわらず<br>その責任から逃げ続けて…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430043")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "否定")
-- ▲直接出力

	--★★エレイン★★:表に出たくない。隠れていたい。独りでいたい<br>役目から逃げたい。誰か代わって欲しい
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430045")

	change_face(Actor002,"Normal")

	--★★エレイン★★:表舞台からはずぅっと離れていたほうが<br>むしろ誰かのためになると思っていました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430046")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_430047")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera003)
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight_reset(Actor002 , 0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-170,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:ですがあの日…<br>先輩に出会った日から
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430049")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:雷に打たれたようで、私──
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:学園でひとりきり、武器を振り回し続けて<br>名も…立場も、変え続けた先輩の話を聞き…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "喜び")
-- ▲直接出力

	--★★エレイン★★:胸が躍りました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430052")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:先輩に近づきたいんです。私
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_430054")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102023)
	InitializeLoad_Preload()
	load_area_scene_preload(115254)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110251_31)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

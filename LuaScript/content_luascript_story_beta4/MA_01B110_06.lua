-- このluaスクリプトは、MA_01B110_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-115,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	Camera002 = SetTemplate("Actor002",65,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera003 = SetTemplate("Actor003",50,CharaPos110061_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_001)
	Camera004 = SetTemplate("Actor004",-150,CharaPos110061_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_006)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
set_pos(Actor002,{-5.2,0,14.5})
set_pos(Actor003,{-10.2,0,10.8})
set_pos(Actor004,{-1.1,0.8,17.5})
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★パーシヴァル★★:ボクが讃えられる早道だと思うがね！
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "否定")
-- ▲直接出力

	--★★ディンドラン★★:急いては事を仕損じます<br>パーシヴァル様
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:黙って携えられたらどうだい<br>ボクのキラーズ…武器ならばさぁ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060005")

-- ▼直接出力
 --PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:ではこのディンドランを携え…抱っこでもして<br>あてどない旅に出られますか？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060006")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★パーシヴァル★★:じ、自分の足で歩け！<br>なんでボクが抱えなきゃならないんだ！
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060007")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Worry")
-- ▲直接出力

	--★★ディンドラン★★:ハァ、パー坊に抱っこされる日が来るなんて<br>義姉さん嬉しいわ
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060008")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★パーシヴァル★★:は、話を聞け！！抱っこはしない！<br>あと学内でパー坊はやめろと何度言ったらわかる
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディンドラン★★:かつては抱っこをねだって離れなかったパー坊が<br>ああ、こぉんなにリッパになったのね
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060010")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:なでなでするな！！話を逸らすな！！<br>ボクのキラーズならボクに口答えするな！！
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060011")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
 --PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:図書院で大きな声は<br>聞かれてしまいますよ、パー坊？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060012")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera005)
wait_time(0.3)
PlayActionDirect(Actor003,"to Greet_one")
wait_time(3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:………フッフン
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060014")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_pos(Actor003,{-5.045,0,12.906})
set_rot(Actor001,{0,-160,0})
set_rot(Actor002,{0,180,0})
set_rot(Actor003,{0,25,0})
PlayActionDirect(Actor001,"to Std_Loop")
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "挨拶")
-- ▲直接出力

	--★★パーシヴァル★★:これはこれは継承者クン。随分と勉強熱心だね<br>勿論今の口論は聞いていないね？
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","MA_01B110_060017","MA_01B110_060018","MA_01B110_060019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:聖杯のことを調べるのに夢中だったんだ<br>意味深な魔女の言葉も気になったし…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B110_060021")

-- ▼直接出力
set_rot(Actor002,{0,80,0})
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:だからなにも聞こえてないよ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B110_060022")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:そういうことにしてくれ<br>ほんと、そういうことにしてくれ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera003)
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ノワール★★:パー坊は甘えん坊なんだな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B110_060025")

	PlayAction(Actor001,"to  Std_Surp")
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")
	change_face(Actor001,"Surprise")

	--★★パーシヴァル★★:おまえぇぇええ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","N","MA_01B110_060026")

	close_cutin()
-- ▼直接出力
setup_small_camera_start(Camera002)
set_enable_auto_lookat(Actor001,true)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
 --PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:もうすごいんですから
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060027")

	PlayAction(Actor001,"to  Std_Angry")
	open_cutin(1,2)
	on_cutin(1,Actor001,"Anger")
	change_face(Actor001,"Anger")

	--★★パーシヴァル★★:おまえぇぇぇええええええ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","N","MA_01B110_060028")

	close_cutin()
	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera003)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to Bow")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:失礼します
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B110_060030")

	PlayAction(Actor001,"to  Std_Surp")
	open_cutin(1,1)
	on_cutin(1,Actor001,"Anger")
	change_face(Actor001,"Anger")

	--★★パーシヴァル★★:おい！さらっと失礼するな！<br>言いふらす気だろう！言いふらす気だなあ！？
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","N","MA_01B110_060031")

	close_cutin()
-- ▼直接出力
setup_small_camera_start(Camera002)
set_enable_auto_lookat(Actor001,true)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
PlayActionDirect(Actor003,"to Std_Loop")
 --PlayPartVoice("ディンドラン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:どうしましょう<br>ディンドラン、はずかしいっ
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060032")

	PlayAction(Actor001,"to  Std_Angry")
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")
	change_face(Actor001,"Surprise")

	--★★パーシヴァル★★:うれしそうだな！！
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","N","MA_01B110_060033")

	close_cutin()
	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
lookat_delay_weight_reset(Actor002 , 0.6)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,80,1)
wait_time(1.0)
PlayActionDirect(Actor002,"to Std_Loop")
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
change_face(Actor002,"Normal")
change_face(Actor001,"Normal")
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:継承者クンからも言ってやってくれないか<br>彼女に
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060035")

	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:あの『聖杯城の巫女』の探知は<br>不発に終わったんだろう？
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060036")


	--★★パーシヴァル★★:ボクも巫女を軽んじているわけではないが<br>恐らくは魔女が一枚上手だったということだ
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060038")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:断定しよう<br>ずばり聖杯は魔女が持っている
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060039")


	--★★パーシヴァル★★:もしくは聖杯の位置を魔女は把握している<br>あるいは思わせぶりな態度でかく乱を狙っている
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","MA_01B110_060041","MA_01B110_060042")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:全然断定できていないぞ…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B110_060044")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★パーシヴァル★★:うるさいな！！<br>断定しようと思ったが判断材料が多すぎる！
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060045")

	change_face(Actor001,"Anger")

	--★★パーシヴァル★★:ゆえに思考を巡らせているんじゃないか！
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060046")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
 --PlayPartVoice("ディンドラン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディンドラン★★:それを人は<br>断定できていないと言うのですよ
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060047")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:フィエナの力は確かだ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B110_060049")

-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
 --PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:予期せぬことが起きたと伺っています
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060050")

	change_face(Actor002,"Sad")

	--★★ディンドラン★★:聖杯の反応はあったというのに<br>魔女を倒したらわからなくなってしまったとか…
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060051")

	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:でまかせを言っている可能性も<br>否定できないんじゃないか？
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060052")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ノワール★★:疑い合っている場合じゃない
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B110_060053")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
 --PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★パーシヴァル★★:だからさ！<br>ボクは考えたのさ！
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060055")

	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:魔女が潜んでそうな場所を<br>片っ端から潰してくんだ、そうすれば──
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060056")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:フィエナ様のお告げを待ちましょう<br>闇雲に動いてはなりませんよ
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060057")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "激怒")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★パーシヴァル★★:戦果をあげるチャンスだと言ってるんだ！<br>聖杯は見つからなくとも魔女への奇襲にはなる！
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060058")

	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:ヴォールスと探偵ムスメに<br>先を越されたくはないんでね！
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060059")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ディンドラン★★:仲間を悪く言うものではありませんよ
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060060")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
Appear(Actor004)
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★フィエナ★★:ノワール！！
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B110_060062")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:フィエナ？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B110_060063")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_pos(Actor004,{-3.314,0,13.246})
set_rot(Actor001,{0,160,0})
set_rot(Actor002,{0,135,0})
set_rot(Actor003,{0,90,0})
set_rot(Actor004,{0,-90,0})
PlayActionDirect(Actor003,"to Std_Loop")
lookat_weight_reset(Actor001)
lookat_weight_reset(Actor002)
lookat_weight_reset(Actor003)
lookat_weight_reset(Actor004)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★パーシヴァル★★:噂をすればだ、このパーシヴァルを見込んで<br>先駆けてお告げを届けに来てくれたのかな？
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_060064")

-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_No")
 --PlayPartVoice("フィエナ", "苦しみ")
-- ▲直接出力

	--★★フィエナ★★:ノワール、ノワール…ごめんね、私…！
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B110_060065")

	change_face(Actor002,"Surprise")

	--★★ディンドラン★★:フィエナ様…？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_060066")

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力

	--★★フィエナ★★:ガラハッドを………
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B110_060067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Joy")
-- ▲直接出力

	--★★フィエナ★★:ガラハッドを、さがして！！
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B110_060068")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

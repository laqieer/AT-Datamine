-- このluaスクリプトは、MA_01C111_08.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
set_pos(Actor001,{-1.9,0,-13.4})
set_rot(Actor001,{0,90,0})
set_rot(Actor002,{0,-100,0})
set_rot(Actor003,{0,100,0})
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110123)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{0.5,0,-13.4},1.5)
wait_time(1)
turn_chara(Actor001,-6,0.5)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:どうしたんだ、ふたりとも<br>そんな暗い顔して
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_080002")

-- ▼直接出力
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor001,true)
 --PlayPartVoice("フレン","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:ノワール…
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★フレン★★:…実はね<br>ローラからの手紙が、来なくて
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080005")


	--★★ノワール★★:手紙？<br>ローラって、確か――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_080006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フレン","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:うん。ルーシャスくんについていって<br>ローマ陣営にいるの
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080007")


	--★★フレン★★:でも、手紙はやりとりしてたんだ<br>小鳥さんが運んでくれてね
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080008")


	--★★フレン★★:それで、元気だってわかってたから<br>私も安心してたんだけど…
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080009")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア","挨拶")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラシア★★:先月から、ぱったりと<br>ローラからの手紙が来なくなったんです
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01C111_080011")

-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力

	--★★ラシア★★:それに…ローマ軍に関わる<br>よくない噂も聞こえ始めて
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01C111_080012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:「ローマ軍は魔女に乗っ取られている」
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080013")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア","落胆")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ラシア★★:馬鹿げたウワサですよ<br>ヴェルナルス様がいるのにそんなことありえない
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01C111_080015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フレン","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:…うん。そうだよね<br>でも…
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080016")

	open_select_window_tag(Actor001,"Normal","MA_01C111_080017","MA_01C111_080018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:今からでもローマに行きたいか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_080020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor001,true)
 --PlayPartVoice("フレン","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:本音を言えばね
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080021")

	change_face(Actor002,"Sad")

	--★★フレン★★:でも、足手まといが増えるだけだって<br>ルーシャスくんに言われちゃいそうだし
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:いっそ、私がルーシャスくんと<ruby=ゲシュタルト・シフト>ＧＳ</ruby>してたら<br>話は違ったのかもだけどね
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080023")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:フレンが、ルーシャスと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_080025")

-- ▼直接出力
set_enable_auto_lookat_all(true)
 --PlayPartVoice("ラシア","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラシア★★:だったら、私はヴェルナルス様とかな<br>なんて…本人がいないから言えることね
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01C111_080026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ラシア★★:ヴェルナルス様は<br>私たちを戦いに巻き込むことを嫌うから
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01C111_080027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フレン","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:そうだね。それにルーシャスくんも
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080028")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
 --PlayPartVoice("フレン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ルーシャスくんってね、ああ見えて<br>意外と優しいところもあるんだ
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080029")

	change_face(Actor002,"Smile")

	--★★フレン★★:それに、ローマの民を守りたいって<br>心から思ってる
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080030")

	change_face(Actor002,"Sad")

	--★★フレン★★:だからきっと、ローラは大丈夫だと思うんだ<br>だけど…
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080031")

	change_face(Actor001,"Sad")

	--★★ノワール★★:フレン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_080033")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:仮にそうだったとしても<br>それは、ルーシャスが選んだ道だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_080035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フレン","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:…うん。そうだよね<br>ノワールにしてみればそう思うよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080037")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★フレン★★:でも、ルーシャスくんには<br>ルーシャスくんの考えがあるんだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080038")

	change_face(Actor002,"Normal")

	--★★フレン★★:君が見ている世界が、君が知っていることが<br>すべて正しいとは限らない
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080039")

-- ▼直接出力
 --PlayPartVoice("フレン","激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:全部を知っているわけじゃないのに<br>知ったふうなこと、言わないで
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080040")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラシア★★:…フレン
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01C111_080041")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フレン","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:…ごめん。八つ当たりしちゃった<br>気持ちが落ち着かなくて
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080043")

	goto Block1end

::Block1end::
	change_face(Actor002,"Sad")

	--★★フレン★★:私たち、もう行くね<br>それじゃ
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01C111_080045")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor002)
Hide(Actor003)
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(2)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_080047")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110123)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

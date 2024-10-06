-- このluaスクリプトは、MA_01B112_49.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115159)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール★★:寒くないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_490002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:平気だ、これくらい
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490003")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力

	--★★ガラハッド★★:雪というのは不思議なものだな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490005")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:雪は多くの不純物を含んでいるのに<br>美しい銀色に見える
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:この街に来て、学園に入学して<br>ガラハッドはたくさん人と触れ合った
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490008")


	--★★ガラハッド★★:コルベニック城にいた頃は<br>他者とあまり触れ合うことなく
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490009")


	--★★ガラハッド★★:お爺様の理想とされる<br>騎士となることだけを考えていた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★ガラハッド★★:それ以外のことは不純なものだと思っていた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490011")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:でも、間違っていたのかもしれない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:他者と関わり、多くを学び吸収することで<br>白銀の輝きは増していくものなのかもしれない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B112_490014","MA_01B112_490015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、きっとそうだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_490017")

	change_face(Actor001,"Smile")

	--★★ノワール★★:現に初めて会った時よりも<br>ガラハッドの瞳は輝いて見えるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_490018")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:…興味深いモノを見るとき<br>人は目を輝かせるとも言うしな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490020")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:だが…少し恥ずかしい<br>そんなに目をキラキラさせていたか…僕は
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490021")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:その…なんだ…<br>お前に見られていたとは──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490022")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:でも、ちょっと嬉しくもある<br>お前が僕を見てくれていたとは
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まぁ、節度はあるだろうけどな<br>不純物は取り込み過ぎないようにしないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_490026")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:せっかくの綺麗な瞳をしているんだから<br>濁ってしまったらもったいない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_490027")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:なっ…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490028")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:お、お前はよくそういうことを<br>平気な顔で言えるな…！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490029")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:………『ガラハッド』という名前、な？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490031")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド★★:汚れを知らない生物は<br>過酷な環境で生きていけないというだろう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490032")


	--★★ガラハッド★★:もはや真意はわからないが<br>もしかしたら…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490033")


	--★★ガラハッド★★:お爺様が僕に<br>最強騎士の幼名を与えたのは──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490034")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:幼く弱い僕を護る鎧として<br>…だったのかもしれない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490036")


	--★★ガラハッド★★:「ランスロットみたく育て」という意味でなく…<br>生きかたを強いるわけでもなく──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:──「ただ、強くあれ」と
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490038")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…やさしい、お爺さんだったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_490039")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:言葉足らずな、お爺様だ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490040")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:………僕も知ろうとしなかった、問えなかった<br>勝手に解釈を先走った
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490041")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力

	--★★ガラハッド★★:わかりあえた…はずだったのに
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490042")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力

	--★★ガラハッド★★:………少し、寒いな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490044")

	open_select_window_tag(Actor001,"Normal","MA_01B112_490045","MA_01B112_490046")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:大きな戦いも控えてる<br>風邪をひく前に寮に戻ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_490048")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:…そうだな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490049")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか温かい食べ物でも<br>用意されてるといいんだが
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_490051")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:………そうだな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490052")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B112_49_Cloth")
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:………コートの金色もきっと<br>父君がお前を護るために纏った鎧なのだろうな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490054")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:…父君がお前たちを護るために纏ったコートを<br>お前は模している………というのに
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490055")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:今は………いいのか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490056")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:僕を護ってくれるのか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490058")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:僕で、いいのか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_490060")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, 3.0)
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
	goto Block2end

::Block2end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115159)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

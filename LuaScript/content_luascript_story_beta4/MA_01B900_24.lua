-- このluaスクリプトは、MA_01B900_24.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110141_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_008)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
load_sound("VO_story01_op")
load_image("10102022", "content_still_10102022_image", "101020220_StillImage")
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.035
--setup_small_camera_resetting(Actor002,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール★★:あんたは最高の騎士だよ<br>ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240002")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:………GSの影響か<br>弱音まで筒抜けとはな、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_240004")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:父さんが遺してくれた４つの真実<br>すべてを見たよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:聖杯はまだ奇跡を起こせる<br>そうだろ？ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240007")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マルディサント★★:…アタシは信じねえぞ<br>モルガンせんせが裏切ったなんざ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_240009")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:ガラハッドから聞いたの…<br>アーサー様が、その…バルバロイの王で、とか
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B900_240010")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ガラハッド★★:…すまない。ディナタンと…<br>ひ、非行少女に詰め寄られて、伝えてしまった
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_240011")


	--★★ガラハッド★★:けど、ノワールやランスロットの家族だろう<br>お、重荷でも、家族と抱えたほうが…いいかもと
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_240012")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Anger")

	--★★フィエナ★★:も、もちろんディナタンもマルディサントも<br>ほかには誰にもバラしてないよっ
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_240013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★フィエナ★★:…ガウェインも、塞ぎこんじゃったケド<br>学園が混乱するようなこと漏らさないよね、多分
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_240014")


	--★★ディナタン★★:…兄さん「聖杯の奇跡はまだ起こせる」って<br>どういうこと…？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B900_240015")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "苦しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★マルディサント★★:………もうお手上げじゃねえの
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_240017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マルディサント★★:バルバロイ殲滅すんには<br>聖杯の力がなきゃどうにもなんねえ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_240018")


	--★★マルディサント★★:聖杯の力を解放するには<br>サラスとかいう場所に行かなきゃなんねえ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_240019")


	--★★マルディサント★★:サラスに入るためには<br>妖精の命が必要、なんだろ？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_240020")

	change_face(Actor006,"Normal")

	--★★フィエナ★★:…聖杯によって<br>ブリテンの穢れを具現化することができて…
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_240021")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:具現化した穢れの中心点を<br>ランス兄ちゃんが討つことで──
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B900_240023")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ガラハッド★★:『聖域化』が行える<br>この地のバルバロイを根絶できる
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_240024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マルディサント★★:だけどその肝心の妖精が…<br>マーリンサマがヤられちまったんだろ？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_240025")


	--★★マルディサント★★:バルバロイは増え続けてる<br>アーサー王はバルバロイの王になる
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_240026")

	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "苦しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★マルディサント★★:…もう止めらんねえじゃん、実際…！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_240028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:いいや
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240029")


	--★★ノワール★★:父さんの記憶と、ランスロットのGSが<br>希望を遺してくれたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240030")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ガラハッド★★:希望…？
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_240032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:妖精ニニアンには子供がいる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240033")


	--★★ノワール★★:人とのあいだに産まれた子供がいるはずなんだ<br>それを父さんに託した
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240035")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ガラハッド★★:よ、妖精と人間のハーフということか！？
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_240036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ハーフが聖杯の力を引き出せるかの<br>確証はないけれど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240037")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Surprise")

	--★★マルディサント★★:み、見つかんねえだろ、ンなヤツ！<br>それにホイホイ命差し出すと思うか…！？
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_240038")

	open_select_window_tag(Actor001,"Normal","MA_01B900_240039","MA_01B900_240040","MA_01B900_240041")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺たちも同じように命を懸ける
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240043")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マルディサント★★:だからいっしょに死のうぜってコト？<br>それは無理強いってヤツじゃねえか
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_240044")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:死は…強いれない、よね
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B900_240045")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:その子の意志を尊重する
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240047")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ガラハッド★★:が、ガラハッドもそれに賛成だ<br>強制される死など…到底受け入れがたい
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_240048")

	change_face(Actor005,"Sad")

	--★★ガラハッド★★:それが仮に<br>世界の終わりに繋がるとしても…
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_240049")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…そうだよな<br>別の方法がないか探してみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240051")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:いや、それは時間が許してくれないだろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_240052")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:これは俺のミスだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_240053")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:俺が早く剣を振り下ろせていれば<br>犠牲も出なかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_240054")

	goto Block1end

::Block1end::
	change_face(Actor005,"Normal")

	--★★ガラハッド★★:その子をさがしてみる価値はある<br>世界が終わるかどうかの瀬戸際なんだ…！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_240056")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:聖杯をさがすよりも難しいかもしれない<br>だけど、なにもしないで終わるよりはいい…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240057")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:………その必要はない、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_240058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240059")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:『妖精の子』の居場所ならわかっている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_240060")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★フィエナ★★:わかっているって、どういうこと？<br>もしかしてもう見つけてある、とか…！？
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_240062")


	--★★ランスロット★★:ノワール…お前の母君の言葉を覚えているか？<br>いつかきっと、遺されたであろう言葉だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_240063")


	--★★ノワール★★:母さんが、遺した言葉…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240064")


	--★★テロップ★★:「だけど忘れないで<br>父さんが全部遺してくれたから」
	Talk(Actor007,"telop","narration","N","MA_01B900_240066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★テロップ★★:「ディナタンを守って」
	Talk(Actor007,"telop","narration","N","MA_01B900_240068")


	--★★ランスロット★★:…師匠が託され、護らなければならなかった子供<br>ノワールを継承者に指名した理由──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_240069")


	--★★ランスロット★★:それは『妖精の子』のためでもあった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_240070")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:まさか──…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_240071")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0,1.0)
wait_time(1.5)
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("10102022", 0.0, 0.0, 0.0 ,true,false)
fadein(2.0)
wait_time(1.5)
voiceSignalS = voice_play("VO_MA_01B900_240072")
wait_time(1.0)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(1.5)
fadeout(0,0,0,1.0,2.0)
wait_time(2.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("VO_story01_op")
load_image_preload("10102022", "content_still_10102022_image", "101020220_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

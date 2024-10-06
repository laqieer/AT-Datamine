-- このluaスクリプトは、MA_01B111_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115157)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フィエナ★★:綺麗だねえ
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ガラハッドがさがしてたよ<br>「姉上がいない！」って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180004")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "照れ")
-- ▲直接出力

	--★★フィエナ★★:えっへへ、心配させちゃった
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:戻ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180006")

	change_face(Actor002,"Normal")

	--★★フィエナ★★:…バルバロイに呑まれちゃった人<br>ノワールは見たことある？
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180007")


	--★★ノワール★★:…？<br>あるよ…たくさんね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180008")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フィエナ★★:幸せなのかな。それって
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B111_180010","MA_01B111_180011","MA_01B111_180012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんなわけないだろ<br>記憶を喰われて、身体は弄ばれてるんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180014")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フィエナ★★:だよね<br>けど、人ならざる力を得る
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180015")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…可能性がある、だろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180016")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フィエナ★★:でもなにか達成したい目的があったとして<br>ほかに手段がないとしたら
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180017")

	change_face(Actor002,"Normal")

	--★★フィエナ★★:あえてその道も選ぶ人も<br>いるのかな
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180018")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:バルバロイは人を襲う<br>その罪を負ってまで達成したい目的なんて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180019")

	change_face(Actor002,"Sad")

	--★★フィエナ★★:だよね
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…望んでそうなった人がいるなら<br>もしかしたら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180022")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フィエナ★★:いたの？
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180023")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:喜んでバルバロイを受け入れたわけじゃないけど<br>望んでいたわけでもないかもしれないが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:家族のためにそうなった人はいた…<br>育ての、父親が
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180025")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フィエナ★★:幸せ………じゃなさそうだね<br>ノワールの顔を見ると
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180027")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:もっと生きていて欲しかったよ<br>ずっと…またいっしょに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180028")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:バルバロイは人を襲う<br>それは許されることではないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フィエナ★★:…うん<br>自分勝手だね
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180031")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:当人がそれで<br>仮に幸せだったとしても
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180032")

	change_face(Actor002,"Sad")

	--★★フィエナ★★:償うべきだよね
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180033")

	goto Block1end

::Block1end::
	change_face(Actor002,"Sad")

	--★★フィエナ★★:銀卓騎士団は、呑まれちゃってた
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180035")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "落胆")
-- ▲直接出力

	--★★フィエナ★★:キラーズにまで侵蝕は及んでないみたいだけど<br>バイブスをもつ騎士たちはガラハッド以外みんな…
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180037")

	PlayAction(Actor002,"to  Std_Talk")

	--★★フィエナ★★:辺境の孤島で<br>ずっと寄り集まって生きて来たの
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180038")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フィエナ★★:自らの役目を果たす以外に生きる世界がない<br>銀卓の矜持だけが彼らにとっての騎士道
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180039")


	--★★フィエナ★★:その魂は高潔にして純粋<br>剣技は鍛え抜かれ最強騎士に届かんばかり
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180040")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★フィエナ★★:バルバロイや魔女にそそのかされたわけじゃない<br>敗れて侵されたとも考えづらい
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180041")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…自ら進んでバルバロイを受け入れた？<br>そうまでして貫きたい矜持ってなんなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180042")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor003,Camera003,EntryData110151_01_05,CameraAssetBundleName110151_01,CameraPos110151_01_105)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:「妖精を守ること」だ<br>本来であれば…銀卓の矜持は
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B111_180044")


	--★★フィエナ★★:もう、そんなのいないのにね
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:…もはやいない存在を守ろうとしている<br>っていうのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180047")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "否定")
-- ▲直接出力

	--★★フィエナ★★:意味わかんないよね。私も…わかんない<br>バルバロイに身を喰わせてまですべきことなのか
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180049")

	change_face(Actor002,"Sad")

	--★★フィエナ★★:だけど、私やガラハッドにとっては家族で<br>仲間でかけがえのない人たちで…
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フィエナ★★:でも、ここから見る夜空も綺麗で<br>学園の人たちも優しくて…
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180051")

	change_face(Actor002,"Sad")

	--★★フィエナ★★:ノワールもランスロットも強くって<br>あの頃からはとっても遠くに感じて…
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180052")

	change_face(Actor002,"Normal")

	--★★フィエナ★★:だから私は…私が選ぶ道は──
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180053")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:…姉上？<br>体を冷やすといけない。帰ろう
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B111_180054")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:………フィエナ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_180056")

	change_face(Actor002,"Sad")

	--★★フィエナ★★:ああ…
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180058")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力

	--★★フィエナ★★:聖杯が。もう
	Talk(Actor002,"CHRNAME_VIENA","speech","L","MA_01B111_180060")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115157)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

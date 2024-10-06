-- このluaスクリプトは、MA_01A111_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_05_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_05_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_007)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ノワール、ノワール
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100002")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ノワール、ノワール、ノワール
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100003")

	open_select_window_tag(Actor001,"Normal","MA_01A111_100005","MA_01A111_100006","MA_01A111_100007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ご機嫌だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_100009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:そう見えるかっ、ノワール
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:だよね、やっぱりねーっ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100011")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだなんだ…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_100012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:聖杯探索お疲れ様
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_100014")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:労いはいらないぞノワール！<br>ガラハッドらは責務を果たしているだけだからな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100015")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:嬉しそうじゃん、ガラハッド
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100016")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:姉上っ、や、やめてください…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100018")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:飛び出したそうじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_100020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:飛び出したわけではないぞ！<br>皆が遅すぎるだけだ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100021")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:足並み揃えようよガラハッド～
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100022")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:円卓の騎士は頼もしい者ばかりだが<br>会議とかたくさんするから困ったものだ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100023")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:銀卓騎士団は人数が少ないからいいの！<br>円卓の騎士たちは人数が多いから必要なの！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100024")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:あまり大きな声では言えないが<br>どうしても直接こっそり伝えたいことがあるんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100026")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:耳貸して、耳貸して
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100027")


	--★★ガラハッド★★:聖杯が見つかる。まもなくな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100029")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	close_cutin()
	change_face(Actor001,"Normal")

	--★★ノワール★★:…まもなく、みつかる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_100031")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:い、意味がわからないぞ…探してたはずだろ？<br>なのに見つかることがわかるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_100033")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ふふふ。このフィエナ──『聖杯城の巫女』と<br>騎士たちの協力によりそれが叶ったの！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100034")

	PlayAction(Actor003,"to Finger")
	change_face(Actor003,"Normal")

	--★★フィエナ★★:巫女が導く騎士たちが４人の悪しき魔女を退治！<br>めでたく聖杯の顕現は秒読み…というわけ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:詳細は省くがな！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100036")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:省くなよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_100037")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "照れ")
-- ▲直接出力

	--★★フィエナ★★:知りたかったらガラハッドたちと一緒に<br>聖杯探索の旅に出るべきだったね～残・念！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:でもお前たちがローマを抑えてくれてたおかげで<br>聖杯探索班が動きやすくなった、礼を言う
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100039")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力

	--★★フィエナ★★:実は魔女たちね<br>聖杯城にもちょっかいかけて来たんだって
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100040")


	--★★ガラハッド★★:だけどお爺様が突っぱねたんだ<br>銀卓騎士団は残して来てたから迎撃も出来た
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100041")

	PlayAction(Actor003,"to  Std_Talk")

	--★★フィエナ★★:「継承者の選択に報いる」<br>って言ってたんだって。おじい様
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:俺の選択…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_100044")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力

	--★★フィエナ★★:よくわかんないけど、おかげで<br>聖杯探索では魔女が邪魔してくるぐらいで済んだ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100045")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:…お爺様の、ログレスに対するお考えは不明瞭だ<br>あるいは敵対する可能性もあったかもしれない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100046")


	--★★ガラハッド★★:だがお爺様はノワールの選択に対して<br>なにかしら思うことがあったんだろう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100047")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:お前の──ガラハッドたちの故郷は<br>銀卓騎士団が守護する
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100048")


	--★★ガラハッド★★:お爺様がその道を選ばれたのであれば<br>迷いなくガラハッドもノワールたちの味方だ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100050")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…ありがとうガラハッド。フィエナ<br>心強いよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_100051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:えっへっへっへ。聖杯が出現したら<br>私ピーンと来るからっ。すぐ知らせるよ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100052")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:敵も聖杯出現の大体の位置は<br>もちろんわかってるだろう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100053")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガラハッド★★:ローマ・バルバロイ・魔女との<br>最後の聖杯争奪戦が始まるぞ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:ノワール、もうすぐだよ<br>終わったらさ…もっかいコルベニックに帰ろうね
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01A111_100055")


	--★★ガラハッド★★:聖杯探索班のプライドにかけて<br>このガラハッドから継承者に──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100056")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:聖杯を手渡してやるからな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01A111_100057")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end

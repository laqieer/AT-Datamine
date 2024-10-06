-- このluaスクリプトは、EA_006_014.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor006)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor007)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor009)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_Gareth")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_2DOnly("101013","001","101013001")
	template1()
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ガレス★★:（ログレスを守る騎士の筆頭――円卓の騎士<br>これでやっと、兄さんと同じ卓を囲める）
	Talk(Actor001,"CHRNAME_GARETH","mind","L","EA_006_0140002")

	change_face(Actor001,"Sad")

	--★★ガレス★★:（――そう、思ってたのに）
	Talk(Actor001,"CHRNAME_GARETH","mind","L","EA_006_0140003")

-- ▼直接出力
setup_small_camera_start()
PlayPartVoiceDirect("モルドレッド","0032")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")

	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","N","EA_006_0140004")

	close_cutin()
-- ▼直接出力
PlayPartVoiceDirect("ケイ","0020")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ケイ★★:勝手に解散しないでもらいたい<br>話し合う議題は山ほどあるのだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","EA_006_0140005")


	--★★ケイ★★:継承者の捜索について<br>カレドニアへの対抗策について――
	Talk(Actor003,"CHRNAME_KAY","speech","L","EA_006_0140006")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:ひとつめ、進展ナシ・成果ゼロ<br>ふたつめ、全員まとめてぶっ潰す
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","EA_006_0140007")

-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0013")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:ほかに言うべきことあるか？<br>補足情報はございますか？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","EA_006_0140008")

-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0009")
-- ▲直接出力

	--★★パーシヴァル★★:特にナシ
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","EA_006_0140009")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0040")
-- ▲直接出力

	--★★ヴォールス★★:いや、あるだろう<br>ないことはないだろう
	Talk(Actor005,"CHRNAME_BORS","speech","L","EA_006_0140010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★パーシヴァル★★:そうかい？でも継承者さがしが<br>清々しいくらい成果がないのは事実だよね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","EA_006_0140011")


	--★★ランスロット★★:………
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","EA_006_0140012")

	change_face(Actor007,"Sad")

	--★★トリスタン★★:カレドニア兵の動きを探ってはいるけど<br>不審な動きをあげたらキリがない
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","EA_006_0140013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0034")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★トリスタン★★:まぁ…「全員まとめてぶっ潰す」<br>としか言いようがないかも
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","EA_006_0140014")

-- ▼直接出力
PlayPartVoiceDirect("ケイ","0021")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ケイ★★:ふむ…どうする、アーサー
	Talk(Actor003,"CHRNAME_KAY","speech","L","EA_006_0140015")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0008")
-- ▲直接出力

	--★★アーサー★★:会議は短いに越したことはない！<br>では今日のところはこれくらいにするか
	Talk(Actor008,"CHRNAME_ARTHUR","speech","L","EA_006_0140016")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:オイ、待てよ<br>まだ話終わってねぇよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","EA_006_0140017")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0025")
-- ▲直接出力

	--★★トリスタン★★:自分が終わらせようとしたくせに
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","EA_006_0140018")

-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0002")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:おい、おめえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","EA_006_0140020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガレス★★:へ？わたしか？
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0140021")

-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:そうだよ、おめえだよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","EA_006_0140022")

	change_face(Actor002,"Smile")

	--★★モルドレッド★★:なに勝手に円卓囲んで座ってやがる<br>円卓の騎士は遊びでやるもんじゃねぇんだぞ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","EA_006_0140023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0015")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガレス★★:失礼だな！勝手にじゃないぞ！<br>ちゃんとアーサー様の許可はもらってる！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0140024")

	change_face(Actor001,"Normal")

	--★★ガレス★★:ですよね、アーサー様！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0140025")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0007")
-- ▲直接出力

	--★★アーサー★★:うむ！許可した！見習いだけどな！
	Talk(Actor008,"CHRNAME_ARTHUR","speech","L","EA_006_0140026")

	change_face(Actor008,"Smile")

	--★★アーサー★★:ガレスは今の円卓に欠けているものを持っている<br>期待しているんだ
	Talk(Actor008,"CHRNAME_ARTHUR","speech","L","EA_006_0140027")

	change_face(Actor001,"Laugh")

	--★★ガレス★★:アーサー様…！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0140028")

-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0012")
-- ▲直接出力

	--★★モルドレッド★★:ハッ…我が王ときたら呑気な学園生活で<br>ずいぶん平和ボケしちまったようですねぇ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","EA_006_0140029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:こんな弱そうな奴に<br>円卓の騎士が務まるワケねぇだろうが
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","EA_006_0140030")

	change_face(Actor001,"Anger")

	--★★ガレス★★:ムッ！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0140031")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ケイ","0013")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:その点については私も同意する
	Talk(Actor003,"CHRNAME_KAY","speech","L","EA_006_0140032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:ガレスは大きな戦いに参加したこともなく<br>戦の経験自体もまだ少ない
	Talk(Actor003,"CHRNAME_KAY","speech","L","EA_006_0140033")

-- ▼直接出力
PlayPartVoiceDirect("ケイ","0018")
-- ▲直接出力

	--★★ケイ★★:見習いとはいえ、円卓入りを認めるのは<br>少し早計ではないか？ 
	Talk(Actor003,"CHRNAME_KAY","speech","L","EA_006_0140034")


	--★★ガレス★★:ムムムッ！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0140035")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0040")
-- ▲直接出力

	--★★ヴォールス★★:そうだろうか<br>俺はそうは思わない
	Talk(Actor005,"CHRNAME_BORS","speech","L","EA_006_0140036")


	--★★ヴォールス★★:確かに戦の経験自体は少ないが<br>出撃した戦での活躍は目を見張るものがある
	Talk(Actor005,"CHRNAME_BORS","speech","L","EA_006_0140037")


	--★★ヴォールス★★:戦場での立ち回りやキラーズとの連携を見ても<br>円卓の騎士となる実力は充分にあると思うが
	Talk(Actor005,"CHRNAME_BORS","speech","L","EA_006_0140038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガウェイン★★:………
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","EA_006_0140039")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0009")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★アーサー★★:ふむ。俺とヴォールスが賛成で<br>義兄さんとモルドレッドが反対派というわけか
	Talk(Actor008,"CHRNAME_ARTHUR","speech","L","EA_006_0140040")


	--★★アーサー★★:ほかの皆はどうだ？
	Talk(Actor008,"CHRNAME_ARTHUR","speech","L","EA_006_0140041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力

	--★★トリスタン★★:表立って反対する理由はないよ<br>賛成する理由もないけど
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","EA_006_0140042")

-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0010")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★パーシヴァル★★:右に同じだね。ぼくの邪魔をしないのなら<br>好きにすればいいんじゃない？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","EA_006_0140043")

-- ▼直接出力
voice_play("VO_101015_sp_0004_1")
-- ▲直接出力

	--★★アーサー★★:ランスは？
	Talk(Actor008,"CHRNAME_ARTHUR","speech","L","EA_006_0140044")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0008")
-- ▲直接出力

	--★★ランスロット★★:アーサーが認めたというのなら<br>俺がどうこう言う必要はない
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","EA_006_0140045")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0034")
-- ▲直接出力

	--★★ランスロット★★:だが諸手を挙げて賛成とも言えない<br>ガレスに経験が不足しているのは事実だ
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","EA_006_0140046")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0046")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★アーサー★★:煮え切らない意見が３人！<br>――まぁ、中立と言ったところか
	Talk(Actor008,"CHRNAME_ARTHUR","speech","L","EA_006_0140047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★アーサー★★:あとは――
	Talk(Actor008,"CHRNAME_ARTHUR","speech","L","EA_006_0140048")

-- ▼直接出力
setup_small_camera_start(Camera009)
set_common_look_at(Actor007,Actor004)
set_common_look_at(Actor008,Actor004)
-- ▲直接出力
	change_face(Actor010,"Serious")

	--★★ガウェイン2★★:
	Talk(Actor010,"CHRNAME_GAWAIN","speech","L","EA_006_0140049")

-- ▼直接出力
set_common_look_at(Actor001,Actor009)
setup_small_camera_start(Camera007)
set_common_look_at(Actor007,Actor009,2)
wait_time(1.1)
setup_small_camera_start(Camera008)
set_common_look_at(Actor008,Actor009,2)
wait_time(1.1)
setup_small_camera_end(Camera008)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガレス★★:兄さん…？
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0140051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor009,"Serious")

	--★★ガウェイン★★:アーサー様の言うことは<br>本当なら全部飲み込みてーとこだけど
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","EA_006_0140052")

	play_head_motion(Actor009, "No", 0.3, 1.0, false)

	--★★ガウェイン★★:でも俺は、絶対認めねぇ
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","EA_006_0140053")


	--★★ガレス★★:な、なんでそんなこと言うんだ…？<br>わたし、頑張ったんだぞ！？すごく、すごく…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0140054")

-- ▼直接出力
voice_play("VO_101013_sp_0006_2")
-- ▲直接出力
	change_face(Actor009,"Anger")

	--★★ガウェイン★★:お前はなんにもわかってねーからだよ
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","EA_006_0140055")


	--★★ガウェイン★★:円卓の騎士に課せられる責任も重圧も<br>並大抵のモンじゃねぇんだ
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","EA_006_0140056")


	--★★ガウェイン★★:円卓の騎士ともなれば、時には戦場で<br>他の兵士を率いて戦うことだってある
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","EA_006_0140057")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0041")
-- ▲直接出力

	--★★ガウェイン★★:小さな戦いにしか出たことのないお前には<br>荷が重すぎるだろ
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","EA_006_0140058")

	PlayAction(Actor001,"to Sit01_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0021")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガレス★★:そんなの分かってるよ！でも…<br>だからこれからがんばろうとしてるんだ！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0140059")


	--★★ガウェイン★★:これからがんばるとか言ってられねーの<br>今まさに戦争中なんだぞ
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","EA_006_0140060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガレス★★:ぐっ…なんだよ。兄さんは反対ばっかりだ！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0140061")


	--★★ガレス★★:わたしが円卓の騎士を目指すって言ったときも<br>女の子がなるもんじゃねー！とか言ってさ！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0140062")

	PlayAction(Actor007,"to Sit01_Talk")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン_002","0017")
-- ▲直接出力
	change_face(Actor007,"Anger")

	--★★トリスタン★★:なにそれ。そんなこと言ったの？
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","EA_006_0140063")


	--★★トリスタン★★:そういう言いかたはないんじゃない？<br>キミのキラーズにも失礼だよ
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","EA_006_0140064")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0043")
-- ▲直接出力

	--★★ガウェイン★★:ぐ…それはまた違う話だろ！？
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","EA_006_0140065")

-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0013")
-- ▲直接出力

	--★★モルドレッド★★:違わねえよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","EA_006_0140066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0045")
-- ▲直接出力

	--★★パーシヴァル★★:ていうかきみ、そんなこと言ったのかい？　<br>思ったよりも妹好きだったんだね
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","EA_006_0140067")

	PlayAction(Actor007,"to Sit01_BA01")
	change_face(Actor007,"Normal")

	--★★トリスタン★★:キミの方が家族好きの圧がすごいと思うけど
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","EA_006_0140068")

-- ▼直接出力
PlayPartVoiceDirect("パーシヴァル","0020")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★パーシヴァル★★:なに？今、なにか言った？
	Talk(Actor004,"CHRNAME_PERCIVAL","speech","L","EA_006_0140069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0010")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★トリスタン★★:なにも。キミの気のせいじゃない？
	Talk(Actor007,"CHRNAME_TRISTAN","speech","L","EA_006_0140071")

-- ▼直接出力
PlayPartVoiceDirect("ケイ","0031")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ケイ★★:ええい、いい加減にしないか！<br>円卓の間は口喧嘩の場所ではないぞ！
	Talk(Actor003,"CHRNAME_KAY","speech","L","EA_006_0140072")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0017")
-- ▲直接出力
	change_face(Actor009,"Serious")

	--★★ガウェイン★★:…とにかく、俺はこいつが<br>円卓入りするのは反対だ！
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","EA_006_0140073")


	--★★ガウェイン★★:なんと言われようと<br>この意見は変わらねーから
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","EA_006_0140074")


	--★★ガレス★★:な…なんだよ、それ<br>兄さんの――
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0140075")

-- ▼直接出力
bgm_play("BGM_Battle_Gareth")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor001,"Anger")

	--★★ガレス★★:兄さんのゼンマイ野郎ーー！！！
	Talk(Actor001,"CHRNAME_GARETH","speech","N","EA_006_0140076")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	close_cutin()
	change_face(Actor005,"Surprise")

	--★★ヴォールス★★:（ゼンマイ…！？）
	Talk(Actor005,"CHRNAME_BORS","mind","L","EA_006_0140077")

	change_face(Actor004,"Surprise")

	--★★パーシヴァル★★:（どういう意味…？）
	Talk(Actor004,"CHRNAME_PERCIVAL","mind","L","EA_006_0140078")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_Battle_Gareth")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_2DOnly_Preload("101013","001","101013001")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
